using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

//systems update order
//1. GetMouseWorldPositionSystem
//2. RotateTurretSystem
//3. RotateGunSystem
//4. DistanceTurretLimitsSystem
//5. PathGeneratorAndBulletSpawnerSystem

[UpdateAfter(typeof(RotateTurretSystem))]
public class RotateGunSystem : JobComponentSystem
{
    [BurstCompile]
    struct RotateGunJob : IJobForEach<RotationEulerXYZ,RotateGunLimits,LocalToWorld>
    {
        [ReadOnly]public float3 CursorWorldPosition;
        
        public void Execute(ref RotationEulerXYZ c0, [ReadOnly]ref RotateGunLimits rotationLimits, [ReadOnly]ref LocalToWorld c2)
        {
            ref var euler = ref c0;
            var position = c2.Position;
            
            ref var minAngle = ref rotationLimits.MinAngleRad;
            ref var maxAngle = ref rotationLimits.MaxAngleRad;
            
            
            //look max closer to mouse pointer
            float distance = math.distance(position, CursorWorldPosition);
            float angle = math.sin(Mathf.Log(distance, math.PI));

            //clamp
            angle = math.clamp(angle, minAngle, maxAngle);

            euler.Value.x = angle;
        }
    }
    
    protected override JobHandle OnUpdate(JobHandle inputDependencies)
    {
        var job = new RotateGunJob()
        {
            CursorWorldPosition = GetSingleton<MainPlayerSharedAimingData>().CursorWorldPosition,
        };
        
        //single player entity with turret
        return job.ScheduleSingle(this, inputDependencies);
    }
}
