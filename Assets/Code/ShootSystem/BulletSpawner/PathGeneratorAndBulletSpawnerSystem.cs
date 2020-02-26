using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;
using Object = UnityEngine.Object;

//systems update order
//1. GetMouseWorldPositionSystem
//2. RotateTurretSystem
//3. RotateGunSystem
//4. DistanceTurretLimitsSystem
//5. PathGeneratorAndBulletSpawnerSystem

[UpdateAfter(typeof(DistanceTurretLimitsSystem))]
public class PathGeneratorAndBulletSpawnerSystem : JobComponentSystem
{
    public const byte pathQuality = 32;
    
    //query
    EntityQuery m_BulletSpawnerQuery;

    
    AimingSharedData m_AimingSharedData;
    
    struct PathGeneratorSystemJob : IJob
    {
        //inputs
        [ReadOnly] public LocalToWorld Matrix;
        [ReadOnly] public float3 EndPosition;
        [ReadOnly] public byte PathQuality;
        
        //input then output
        [WriteOnly]public NativeArray<Vector3> PathInOut;
        
        //output

        public float3 PathCenter;
        
        void GenerateBulletPath(ref float3 endPosition,quaternion rot,float sqrHalfDistance)
        {
            int i = 0;
            for (float theta = math.PI; theta > 0; theta -= 0.1f)
            {
                float3 point = new float3(math.cos(theta), math.sin(theta), 0) * sqrHalfDistance;
                PathInOut[i] =  PathCenter + math.mul(rot, point.xyz);;
                i++;
            }

            PathInOut[PathQuality-1] = endPosition;
        }

        void GenerateAlgorithmParams(LocalToWorld matrix,out float sqrHalfDistance,out float3 alignedEndPoint,out quaternion rot)
        {
            sqrHalfDistance= math.distance(matrix.Position, EndPosition) / 2;

            //calculate balistics
            

            rot = quaternion.LookRotation(matrix.Right,math.up());
        
            var point = new float3(math.cos(0), math.sin(0), 0) * sqrHalfDistance;
        
            PathCenter = matrix.Position + matrix.Forward * sqrHalfDistance;
            
            alignedEndPoint = PathCenter + math.mul(rot, point);
        }
        
        public void Execute()
        {
            GenerateAlgorithmParams(Matrix,out var sqrHalfDistance,out var alignedEndPoint,out var rotation);
            GenerateBulletPath(ref alignedEndPoint,rotation,sqrHalfDistance);
        }

    }

    protected override void OnStartRunning()
    {
        //queries
        m_BulletSpawnerQuery = GetEntityQuery(typeof(BulletSpawnerEntity), typeof(LocalToWorld));
        
        //getting Singleton of AimingSharedData
        var aimingDataQuery = GetEntityQuery(typeof(AimingSharedData));
        
        m_AimingSharedData = EntityManager.GetSharedComponentData<AimingSharedData>(aimingDataQuery.GetSingletonEntity());
        
        base.OnStartRunning();
    }

    protected override JobHandle OnUpdate(JobHandle inputDependencies)
    {
        var sharedAimingData = GetSingleton<MainPlayerSharedAimingData>();
        
        //now system is targeted for only one bullet spawner
        var spawnerEntity = m_BulletSpawnerQuery.GetSingletonEntity();

        bool isAiming = Input.GetKey(KeyCode.Mouse1);
        bool isShootClick = Input.GetKeyUp(KeyCode.Mouse0);
        
        if (isAiming || isShootClick)
        {
            if (isAiming)
            {
                //line renderer and aim enabling
                m_AimingSharedData.isVisible = sharedAimingData.IsInAimingDistance;

                //set aim to this world space position
                m_AimingSharedData.Aim.position = sharedAimingData.CursorWorldPosition;
            }

            //now system is targeted for only one bullet spawner

            LocalToWorld matrix = EntityManager.GetComponentData<LocalToWorld>(spawnerEntity);

            var pathOutput = new NativeArray<Vector3>(pathQuality, Allocator.TempJob);

            //generate bullet path
            var generateBulletPath = new PathGeneratorSystemJob()
            {
                //now works for 1 bullet spawner,but can be expanded
                Matrix = matrix,
                EndPosition = sharedAimingData.CursorWorldPosition,
                PathQuality = pathQuality,
                PathInOut = pathOutput,
            };
            inputDependencies = generateBulletPath.Schedule(inputDependencies);

            inputDependencies.Complete();
            
            //preview trajectory or spawn bullet
            if (isAiming) m_AimingSharedData.LineRenderer.SetPositions(pathOutput.ToArray());
            if (isShootClick && sharedAimingData.IsInAimingDistance)
                InstantiateBulletAndSmoke(spawnerEntity, matrix.Position, matrix.Rotation, in pathOutput,
                    in generateBulletPath.PathCenter);

            pathOutput.Dispose();
        }
        //line renderer and aim disabling
        else m_AimingSharedData.isVisible = false;

        return inputDependencies;
    }

    void InstantiateBulletAndSmoke(Entity spawnerEntity,float3 position,Quaternion rotation,in NativeArray<Vector3> pathPoints,in float3 pathCenter)
    {
        BulletSpawnerEntity spawner = EntityManager.GetSharedComponentData<BulletSpawnerEntity>(spawnerEntity);
                
        //this can't be used :( because of particle system has no conversion
        //var entity = EntityManager.Instantiate(spawner.SmokePrefab);
        var smokeParticle = Object.Instantiate(spawner.SmokePrefab,position,rotation);
        Object.Destroy(smokeParticle,spawner.SmokeLifeTime);
                
        var entity = EntityManager.Instantiate(spawner.BulletPrefab);
        EntityManager.SetComponentData(entity,new Translation(){Value = position});
                    
        var bulletPaths = EntityManager.GetBuffer<BulletPath>(entity);
        foreach (var i in pathPoints) 
            bulletPaths.Add(new BulletPath() {Point = i});
        EntityManager.SetComponentData(entity,new BulletPathCenter()
        {
            Center = pathCenter,
        });
    }
}