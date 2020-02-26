using System;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

[GenerateAuthoringComponent]
public struct TankVelocity : IComponentData
{
    //temp
    [HideInInspector]public float LeftWheelPairsSpeed;
    [HideInInspector]public float RightWheelPairsSpeed;
    public float CurrentSpeed;
    
    
    public int MaxSpeed;

    public float BoostRatePercent;
}