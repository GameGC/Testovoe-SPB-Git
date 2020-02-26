using Unity.Entities;
using UnityEngine;

public class DistanceTurretLimitsAuthoring : MonoBehaviour, IConvertGameObjectToEntity
{
    public float minDistance;
    public float maxDistance;
    
    public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
    {
        dstManager.AddComponentData(entity,new DistanceTurretLimit()
        {
            MinDistanceSqr = minDistance * minDistance,
            MaxDistanceSqr = maxDistance * maxDistance,
        });
    }
}

public struct DistanceTurretLimit : IComponentData
{
    //multiplied by 2 to speed up distance equality
    
    public float MinDistanceSqr;
    public float MaxDistanceSqr;
}