using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

public class RotateTurretLimitsAuthoring : MonoBehaviour,IConvertGameObjectToEntity
{
    public float MaxRotationSpeed;
    
    public float MinAngleDeg;
    public float MaxAngleDeg;
    
    /// <summary>
    /// conversion degrees to radians
    /// </summary>
    public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
    {
        dstManager.AddComponentData(entity, new RotateTurretLimits()
        {
            MinAngleRad = math.radians(MinAngleDeg),
            MaxAngleRad = math.radians(MaxAngleDeg)
        });
        dstManager.AddComponentData(entity, new RotateTurretVelocity()
        {
            CurrentRotationSpeed = 0,
            MaxRotationSpeed = MaxRotationSpeed
        });
        
        //Quaternion has some bugs maybe so RotationEulerXYZ is better for my purposes
        if (!dstManager.HasComponent<RotationEulerXYZ>(entity))
        {
            Quaternion q = dstManager.GetComponentData<Rotation>(entity).Value;
            dstManager.AddComponentData(entity,new RotationEulerXYZ(){Value = q.eulerAngles});
        }
            
       //dstManager.RemoveComponent<Rotation>(entity);
       //dstManager.AddComponentData(entity, new RotationEulerXYZ(
       //)
       //{
       //    Value = transform.eulerAngles
       //});
    }
}
public struct RotateTurretLimits : IComponentData
{
    public float MinAngleRad;
    public float MaxAngleRad;
}

public struct RotateTurretVelocity : IComponentData
{
    //per degrees
    public float CurrentRotationSpeed;
    //per degrees
    public float MaxRotationSpeed;
}
