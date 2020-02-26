using Unity.Entities;
using Unity.Mathematics;

public struct MainPlayerSharedAimingData : IComponentData
{
    public float3 CursorWorldPosition;
    
    //do not off system that controls it!
    public bool IsInAimingDistance;
}
