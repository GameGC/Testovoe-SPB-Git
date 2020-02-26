using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

public class RotateGunLimitsAuthoring : MonoBehaviour,IConvertGameObjectToEntity
{
    public float MinAngleDeg;
    public float MaxAngleDeg;
    
    /// <summary>
    /// conversion degrees to radians
    /// </summary>
    public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
    {
        dstManager.AddComponentData(entity, new RotateGunLimits()
        {
            MinAngleRad = math.radians(MinAngleDeg),
            MaxAngleRad = math.radians(MaxAngleDeg)
        });
        
        //Quaternion has some bugs maybe so RotationEulerXYZ is better for my purposes
        if (!dstManager.HasComponent<RotationEulerXYZ>(entity))
        {
            Quaternion q = dstManager.GetComponentData<Rotation>(entity).Value;
            dstManager.AddComponentData(entity,new RotationEulerXYZ(){Value = q.eulerAngles});
        }
    }
}
public struct RotateGunLimits : IComponentData
{
    public float MinAngleRad;
    public float MaxAngleRad;
}
