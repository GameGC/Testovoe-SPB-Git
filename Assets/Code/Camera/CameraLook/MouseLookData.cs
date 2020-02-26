using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

[GenerateAuthoringComponent]
public struct MouseLookData : IComponentData
{
    public float Sensitivity;

    public float MinimumX;
    public float MaximumX;

    public float MaximumY;
    public float MinimumY;

    //temp data
    [HideInInspector] public float RotationY;
    [HideInInspector] public float RotationX;
 
    [HideInInspector] public Entity Target;
    [HideInInspector] public float3 LastCameraOrbitPosition;
}
