using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;
using quaternion = Unity.Mathematics.quaternion;

[AlwaysSynchronizeSystem]
public class BulletFlySystem : JobComponentSystem
{
    [BurstCompile]
    struct BulletFlyJob : IJobForEach_BCCCCC<BulletPath,BulletPathCenter,BulletPathPositionIndex,Translation, Rotation,LocalToWorld>
    {
        [ReadOnly]public float DeltaTime;

        const float flySpeed = 10;

        public void Execute(DynamicBuffer<BulletPath> b0, ref BulletPathCenter c1, ref BulletPathPositionIndex c2, ref Translation c3, ref Rotation c4,ref LocalToWorld c5)
        {
            ref int i = ref c2.PositionIndex;
            if (!(i > 0)) return;
            
            c3.Value = Vector3.MoveTowards(b0[i].Point,b0[i - 1].Point,flySpeed*DeltaTime);
            c4.Value = quaternion.LookRotation(math.normalize(c5.Forward-c1.Center),Vector3.up);
            i--;
        }
    }

    protected override JobHandle OnUpdate(JobHandle inputDependencies)
    {
        var flyJob = new BulletFlyJob()
        {
            DeltaTime = Time.DeltaTime
        };
        inputDependencies = flyJob.Schedule(this, inputDependencies);
        inputDependencies.Complete();
        
        
        //list of bullets those reached end path
        NativeList<Entity> destroyEntities = new NativeList<Entity>(Allocator.Temp);
        
        Entities.WithoutBurst().ForEach((ref Entity entity, ref BulletPathPositionIndex index, ref Translation position,
            in BulletFlightEntity data) =>
        {
            if (!(index.PositionIndex > 0))
            {
                //instantiate particle system
                var explosion = Object.Instantiate(data.ExplosionPrefab, position.Value, quaternion.identity);
                Object.Destroy(explosion, 5);

                //add entity to destroy list,because of not supporting command buffers here
                destroyEntities.Add(entity);
            }
        }).Run();

         foreach (var entity in destroyEntities) 
             EntityManager.DestroyEntity(entity);

         return inputDependencies;
    }
}