using System;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class BulletSpawnerAuthoring : MonoBehaviour,IConvertGameObjectToEntity,IDeclareReferencedPrefabs
{
    public GameObject BulletPrefab;
    
    public GameObject SmokePrefab;
    public float smokeLifeTime;
    
    public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
    {
        dstManager.AddSharedComponentData(entity,new BulletSpawnerEntity()
        {
            BulletPrefab = conversionSystem.GetPrimaryEntity(BulletPrefab),
            SmokePrefab = SmokePrefab,
            SmokeLifeTime = smokeLifeTime,
        });
    }

    public void DeclareReferencedPrefabs(List<GameObject> referencedPrefabs)
    {
        referencedPrefabs.Add(BulletPrefab);
    }
}

public struct BulletSpawnerEntity : ISharedComponentData,IEquatable<BulletSpawnerEntity>
{
    public Entity BulletPrefab;
    
    public GameObject SmokePrefab;
    public float SmokeLifeTime;

    public bool Equals(BulletSpawnerEntity other)
    {
        return BulletPrefab.Equals(other.BulletPrefab) && Equals(SmokePrefab, other.SmokePrefab);
    }

    public override int GetHashCode()
    {
        unchecked
        {
            return (BulletPrefab.GetHashCode() * 397) ^ (SmokePrefab != null ? SmokePrefab.GetHashCode() : 0);
        }
    }
}