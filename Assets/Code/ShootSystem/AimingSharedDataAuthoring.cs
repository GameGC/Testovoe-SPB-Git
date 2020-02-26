using System;
using System.Diagnostics.CodeAnalysis;
using Unity.Entities;
using UnityEngine;


public class AimingSharedDataAuthoring : SharedComponentDataProxy<AimingSharedData> { }

[Serializable]
public partial struct AimingSharedData : ISharedComponentData,IEquatable<AimingSharedData>
{
    public LineRenderer LineRenderer;
    public Transform Aim;

    public bool isVisible
    {
        set
        {
            Aim.gameObject.SetActive(value);
            LineRenderer.enabled = value;
        }
    }
    
    public bool Equals(AimingSharedData other) => other.GetHashCode() == GetHashCode();

    [SuppressMessage("ReSharper", "NonReadonlyMemberInGetHashCode")]
    public override int GetHashCode()
    {
        int hash = 1;
        if (LineRenderer) hash += Mathf.Abs(LineRenderer.GetHashCode());
        if (Aim) hash += Mathf.Abs(Aim.GetHashCode());
        return hash;
    }
}
