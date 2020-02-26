using Unity.Entities;
using Unity.Mathematics;

[InternalBufferCapacity(32)]
public struct BulletPath : IBufferElementData
{
    public float3 Point;
}

public struct BulletPathCenter : IComponentData
{
    public float3 Center;
}
public struct BulletPathPositionIndex : IComponentData
{
    public int PositionIndex;
}
