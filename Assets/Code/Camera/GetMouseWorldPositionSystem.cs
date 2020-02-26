using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

//systems update order
//1. GetMouseWorldPositionSystem
//2. RotateTurretSystem
//3. RotateGunSystem
//4. DistanceTurretLimitsSystem
//5. PathGeneratorAndBulletSpawnerSystem

[UpdateBefore(typeof(RotateTurretSystem))]
public class GetMouseWorldPositionSystem : JobComponentSystem
{
    //persistent reference
    Camera m_Camera;
    
    protected override void OnStartRunning()
    {
        //first constant entity available by default on scene
        var initialEntity = new Entity() {Index = 0, Version = 1};
        EntityManager.AddComponentData(initialEntity,new MainPlayerSharedAimingData());
        SetSingleton(EntityManager.GetComponentData<MainPlayerSharedAimingData>(initialEntity));
        
        //getting persistent reference
        m_Camera = Camera.main;

        base.OnStartRunning();
    }

    protected override JobHandle OnUpdate(JobHandle inputDependencies)
    {
        RayCastGetWorldMousePoint(ref inputDependencies,out var resultHitPoint);
        
        //read 
        var sharedAimingData = GetSingleton<MainPlayerSharedAimingData>();
        
        //write to singleton data,that need be shared between systems
        sharedAimingData.CursorWorldPosition = resultHitPoint;
        SetSingleton(sharedAimingData);

        return inputDependencies;
    }
    
    void RayCastGetWorldMousePoint(ref JobHandle inputDependencies,out float3 resultHitPoint)
    {
        using (var results = new NativeArray<RaycastHit>(1, Allocator.TempJob))
        {
            var commands = new NativeArray<RaycastCommand>(1, Allocator.TempJob);

            // Set the data of the first command
            var ray = m_Camera.ScreenPointToRay(Input.mousePosition);

            commands[0] = new RaycastCommand(ray.origin,ray.direction);

            // Schedule the batch of raycasts
            inputDependencies = RaycastCommand.ScheduleBatch(commands, results, 1, inputDependencies);

            // Wait for the batch processing job to complete
            inputDependencies.Complete();

            resultHitPoint = results[0].point;

            commands.Dispose();
        }   
    }
}
