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

[UpdateAfter(typeof(RotateGunSystem))]
public class DistanceTurretLimitsSystem : JobComponentSystem
{
    EntityQuery m_TurretQuery;

    //persistent reference

    protected override void OnCreate()
    {
        //query
        m_TurretQuery = GetEntityQuery(typeof(RotateGunLimits));
        
        base.OnCreate();
    }

    protected override JobHandle OnUpdate(JobHandle inputDependencies)
    {
        //single player entity with turret
        var turretEntity = m_TurretQuery.GetSingletonEntity();
        
        var distanceLimits = EntityManager.GetComponentData<DistanceTurretLimit>(turretEntity);
        var position = EntityManager.GetComponentData<LocalToWorld>(turretEntity).Position;

        
        //read
        var sharedAimingData = GetSingleton<MainPlayerSharedAimingData>();
        
        float distanceSqr = math.distancesq(position, sharedAimingData.CursorWorldPosition);
        
        //is distance between min and max?
        //write to singleton copy data,that need be shared between systems
        sharedAimingData.IsInAimingDistance = distanceSqr > distanceLimits.MinDistanceSqr && distanceSqr < distanceLimits.MaxDistanceSqr;
        
        SetSingleton(sharedAimingData);

        return inputDependencies;
    }
}