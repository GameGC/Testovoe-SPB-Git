using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

//Movement Systems Order
//1. TankInputSystem
//2. TankMoveSystem
//3. TankMoveSystem

public class TankInputSystem : JobComponentSystem
{
    [RequireComponentTag(typeof(PlayerTag))]
    [BurstCompile]
    struct CalculateInput : IJobForEach<TankVelocity>
    {
        [ReadOnly] public float FwdBackwardInput;
        [ReadOnly] public float LeftRightInput;
        [ReadOnly] public float DeltaTime;

        public void Execute(ref TankVelocity tankVelocity)
        {
            tankVelocity.CurrentSpeed = DeltaTime * tankVelocity.BoostRatePercent * (FwdBackwardInput - LeftRightInput * 0.5f);

            //forward/back move
            if (math.abs(FwdBackwardInput) > math.abs(LeftRightInput))
            {
                tankVelocity.LeftWheelPairsSpeed = FwdBackwardInput - LeftRightInput * 0.5f;
                tankVelocity.RightWheelPairsSpeed = FwdBackwardInput - LeftRightInput * 0.5f;
            }
            else
            {
                tankVelocity.LeftWheelPairsSpeed = -LeftRightInput - FwdBackwardInput * 0.5f;
                tankVelocity.RightWheelPairsSpeed = LeftRightInput + FwdBackwardInput * 0.5f;
            }
        }
    }

    protected override JobHandle OnUpdate(JobHandle inputDependencies)
    {
        var job = new CalculateInput()
        {
            FwdBackwardInput = Input.GetAxis("Vertical"),
            LeftRightInput = Input.GetAxis("Horizontal"),
            DeltaTime = Time.DeltaTime
        };
        
        // Now that the job is set up, schedule it to be run. 
        return job.Schedule(this, inputDependencies);
    }
}