using System;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class BulletDataAuthoring : MonoBehaviour,IConvertGameObjectToEntity,IDeclareReferencedPrefabs
{
    public GameObject ExplosionPrefab;

    public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
    {
        dstManager.AddSharedComponentData(entity, new BulletFlightEntity()
        {
            ExplosionPrefab = ExplosionPrefab
        });
        dstManager.AddComponentData(entity, new BulletPathCenter());
        dstManager.AddComponentData(entity, new BulletPathPositionIndex()
        {
            PositionIndex = PathGeneratorAndBulletSpawnerSystem.pathQuality - 1
        });
        dstManager.AddBuffer<BulletPath>(entity);
    }
    public void DeclareReferencedPrefabs(List<GameObject> referencedPrefabs)
    {
        referencedPrefabs.Add(ExplosionPrefab);
    }
    
}
public struct BulletFlightEntity : ISharedComponentData,IEquatable<BulletFlightEntity>
{
    public float BulletFlyStepEffectTime;
    public GameObject ExplosionPrefab;

    public bool Equals(BulletFlightEntity other)
    {
        return BulletFlyStepEffectTime.Equals(other.BulletFlyStepEffectTime) && Equals(ExplosionPrefab, other.ExplosionPrefab);
    }

    public override int GetHashCode()
    {
        unchecked
        {
            return (BulletFlyStepEffectTime.GetHashCode() * 397) ^ (ExplosionPrefab != null ? ExplosionPrefab.GetHashCode() : 0);
        }
    }
}
