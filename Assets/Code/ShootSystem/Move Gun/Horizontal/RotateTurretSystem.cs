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

[UpdateAfter(typeof(GetMouseWorldPositionSystem))]
public class RotateTurretSystem : JobComponentSystem
{
    [BurstCompile]
    struct RotationTurretJob: IJobForEach<RotationEulerXYZ,LocalToWorld,RotateTurretVelocity,RotateTurretLimits>
    {
        [ReadOnly] public float3 CursorPosition;
        [ReadOnly] public float DeltaTime;
        
        public void Execute(ref RotationEulerXYZ c0, [ReadOnly]ref LocalToWorld c1, ref RotateTurretVelocity velocity, [ReadOnly] ref RotateTurretLimits limits)
        {
            ref var euler = ref c0.Value;
            var turretPosition = c1.Position;
            
            float angleBetweenTurretAndCursor = EulerAnglesBetween(CursorPosition,turretPosition).y;

            //calculating turret rotation speed with extra slowing lerp
            velocity.CurrentRotationSpeed = CalculateRotationSpeed(velocity.CurrentRotationSpeed,
                in velocity.MaxRotationSpeed, in angleBetweenTurretAndCursor);
            
            
            euler.y = math.radians((Mathf.LerpAngle(math.degrees(euler.y),angleBetweenTurretAndCursor,DeltaTime*velocity.CurrentRotationSpeed)));

            //clamp if turret has rotation limits
            euler.y = math.clamp(euler.y, limits.MinAngleRad, limits.MaxAngleRad);
        }
        
        //because of Vector2,3.Angle,SignedAngle not works...
        static float3 EulerAnglesBetween(float3 a, float3 b) => Quaternion.LookRotation(a - b, math.up()).eulerAngles;

        static float CalculateRotationSpeed(float previousSpeed,in float maxSpeed, in float angle)
        {
            return math.clamp(math.lerp(previousSpeed, maxSpeed, math.abs(angle) * previousSpeed),0.01f,maxSpeed);
        }
    }

    protected override JobHandle OnUpdate(JobHandle inputDependencies)
    {
        var job = new RotationTurretJob()
        {
            CursorPosition = GetSingleton<MainPlayerSharedAimingData>().CursorWorldPosition,
            DeltaTime = Time.DeltaTime
        };
        
        //single player entity with turret
        return job.ScheduleSingle(this,inputDependencies);
    }
}