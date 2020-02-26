using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

/// <summary>
/// remake of classical MouseLook script using DOTS
/// </summary>
public class MouseLookSystem : ComponentSystem
{
    Transform m_CameraOrbit;
    
    protected override void OnStartRunning()
    {
        //queries
        var playerQuery = GetEntityQuery(typeof(PlayerTag));
        var mouseLookDataQuery = GetEntityQuery(typeof(MouseLookData),typeof(Transform));
        
        m_CameraOrbit = mouseLookDataQuery.ToComponentArray<Transform>()[0];
        
        //find singleton MouseLookData and save it
        var singleton = mouseLookDataQuery.GetSingleton<MouseLookData>();
        
        //set initial data
        singleton.Target = playerQuery.GetSingletonEntity();
        singleton.LastCameraOrbitPosition = m_CameraOrbit.position;
        SetSingleton(singleton);
        
        base.OnStartRunning();
    }
    

    protected override void OnUpdate()
    {
        var data = GetSingleton<MouseLookData>();
        MoveAndRotate(ref data,EntityManager.GetComponentData<Translation>(data.Target));
        SetSingleton(data);
    }

    void MoveAndRotate(ref MouseLookData data,Translation targetPosition)
    {
        ref var sensitivity = ref data.Sensitivity;
        
        ref var minimumX = ref data.MinimumX;
        ref var maximumX = ref data.MaximumX;
        
        ref var minimumY = ref data.MinimumY;
        ref var maximumY = ref data.MaximumY;

        ref var rotationX = ref data.RotationX;
        ref var rotationY = ref data.RotationY;


        rotationX = m_CameraOrbit.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivity;
        rotationY += Input.GetAxis("Mouse Y") * sensitivity;
        rotationY = math.clamp(rotationY, minimumY, maximumY);
        rotationX = math.clamp(rotationX, minimumX, maximumX);
        m_CameraOrbit.localEulerAngles = new float3(-rotationY, rotationX, 0);

        data.LastCameraOrbitPosition = math.lerp(data.LastCameraOrbitPosition, targetPosition.Value, Time.DeltaTime * 8);
        m_CameraOrbit.position = data.LastCameraOrbitPosition;
    }
}
