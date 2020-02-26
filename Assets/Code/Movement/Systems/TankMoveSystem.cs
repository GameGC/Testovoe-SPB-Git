using Unity.Burst;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Physics.Extensions;
using Unity.Transforms;

//Movement Systems Order
//1. TankInputSystem
//2. TankMoveSystem
//3. TankMoveSystem

[UpdateAfter(typeof(TankInputSystem))]
public class TankMoveSystem : JobComponentSystem
{
    const float half = 0.5f;
    
    [BurstCompile]
    struct TankMoveJob : IJobForEach<TankVelocity,PhysicsVelocity,PhysicsMass,LocalToWorld,Rotation>
    {
        public void Execute(ref TankVelocity velocity, ref PhysicsVelocity physicsVelocity, ref PhysicsMass c2, ref LocalToWorld c3,
            ref Rotation rotation)
        {
            float leftInput = velocity.LeftWheelPairsSpeed;
            float rightInput = velocity.RightWheelPairsSpeed;

            var forward = c3.Forward;
            var right = c3.Right;
            
            var linear= c2.InverseInertia;

            //forward movement
            if (leftInput > half && rightInput > half) linear += forward * ((leftInput + rightInput)*velocity.CurrentSpeed);
            else if(leftInput < -half && rightInput < -half) linear -=forward * ((leftInput + rightInput) * velocity.CurrentSpeed);
            
            //left -right movement
            if(leftInput != rightInput)
            {
                float leftRightSpeedBoost = velocity.CurrentSpeed;
                if (leftInput > rightInput)
                {
                    leftRightSpeedBoost *= velocity.LeftWheelPairsSpeed;
                    linear += -right * leftRightSpeedBoost;
                    rotation.Value = math.mul(rotation.Value,quaternion.RotateY(math.radians(-leftRightSpeedBoost)));
                }
                else
                {
                    leftRightSpeedBoost *= velocity.RightWheelPairsSpeed;
                    linear += -right * leftRightSpeedBoost;

                    rotation.Value = math.mul(rotation.Value,quaternion.RotateY(math.radians(leftRightSpeedBoost *linear.z)));
                }
            }

            physicsVelocity.ApplyLinearImpulse(c2,linear);
        }
    }
    protected override JobHandle OnUpdate(JobHandle inputDependencies)
    {
        var job = new TankMoveJob();
        
        return job.Schedule(this, inputDependencies);
    }
}