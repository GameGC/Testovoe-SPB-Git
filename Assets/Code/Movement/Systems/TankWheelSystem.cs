using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;

//Movement Systems Order
//1. TankInputSystem
//2. TankMoveSystem
//3. TankMoveSystem

[UpdateAfter(typeof(TankMoveSystem))]
public class TankWheelSystem : JobComponentSystem
{
    EndSimulationEntityCommandBufferSystem m_EndFrameBarier;

    [BurstCompile]
    struct WheelUpdJob : IJobForEachWithEntity_EBC<TankWheelPair, TankVelocity>
    {
        [ReadOnly]public ComponentDataFromEntity<Rotation> rotations;

        [NativeDisableParallelForRestriction, WriteOnly]
        public EntityCommandBuffer.Concurrent CommandBuffer;

        public void Execute(Entity entity, int index, [ReadOnly] DynamicBuffer<TankWheelPair> b0, [ReadOnly] ref TankVelocity c1)
        {
            //Unity.Entities.World.Active.EntityManager.SetComponentData();
            foreach (var wheel in b0)
            {
                var quaternion0 = quaternion.RotateY(math.radians(c1.CurrentSpeed * 2 * c1.LeftWheelPairsSpeed));
                var quaternion1 = quaternion.RotateY(math.radians(c1.CurrentSpeed * 2 * c1.RightWheelPairsSpeed));

                //merge with prev rotation
                var rotation0 = new Rotation() {Value = math.mul(rotations[wheel.LeftEntity].Value, quaternion0)};
                var rotation1 = new Rotation() {Value = math.mul(rotations[wheel.RightEntity].Value, quaternion1)};
                
                CommandBuffer.SetComponent(index, wheel.LeftEntity, rotation0);
                CommandBuffer.SetComponent(index, wheel.RightEntity, rotation1);
            }
        }
    }

    EntityCommandBuffer? m_MCommandBuffer;
   
   protected override void OnCreate()
   {
       base.OnCreate();
       m_EndFrameBarier = World.GetOrCreateSystem<EndSimulationEntityCommandBufferSystem>();
   }

   protected override JobHandle OnUpdate(JobHandle inputDependencies)
    {

        var job = new WheelUpdJob()
        {
            CommandBuffer = m_EndFrameBarier.CreateCommandBuffer().ToConcurrent(),
            rotations = GetComponentDataFromEntity<Rotation>()
        };
        
        inputDependencies =  job.Schedule(this, inputDependencies);
        m_EndFrameBarier.AddJobHandleForProducer(inputDependencies);
        
        return inputDependencies;
    }
}