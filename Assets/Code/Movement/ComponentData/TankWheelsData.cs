using Unity.Entities;
using UnityEngine;

public class TankWheelsData : MonoBehaviour,IConvertGameObjectToEntity
{
    [SerializeField] Transform[] leftWheels;
    [SerializeField] Transform[] rightWheels;

    
    public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
    {
        dstManager.AddBuffer<TankWheelPair>(entity);
        var buffer = dstManager.GetBuffer<TankWheelPair>(entity);

        int count = leftWheels.Length;
        buffer.Capacity = count;

        for (var i = 0; i < count; i++)
        {
            var leftWheel = leftWheels[i];
            var rightWheel = rightWheels[i];

            buffer.Add(new TankWheelPair()
            {
                LeftEntity = conversionSystem.GetPrimaryEntity(leftWheel),
                RightEntity = conversionSystem.GetPrimaryEntity(rightWheel),
            });
        }
    }
}

public struct TankWheelPair : IBufferElementData
{
    public Entity LeftEntity;
    public Entity RightEntity;
}