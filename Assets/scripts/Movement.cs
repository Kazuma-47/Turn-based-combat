using UnityEngine;

public class Movement : MonoBehaviour
{
	[Header("Movement Debug")]
	private Rigidbody2D RB;
	public bool Decelaration;
	public bool canJumped;
	public MovementSettings MovementData;

	private void Awake()
	{
		RB = GetComponent<Rigidbody2D>();	
	}
   

	
    public void Run(float lerpAmount , Vector2 input)
	{
		//gives a slipery effect when you run and try to turn or stop
			float targetSpeed = input.x * MovementData.maxRunSpeed;
			targetSpeed = Mathf.Lerp(RB.velocity.x, targetSpeed, lerpAmount);
			float accelRate;

			accelRate = (Mathf.Abs(targetSpeed) > 0.01f) ? MovementData.runAccelAmount : MovementData.runDeccelAmount;

			float speedDif = targetSpeed - RB.velocity.x;

			float movement = accelRate * speedDif;
			RB.AddForce(movement * Vector2.right, ForceMode2D.Force);
	}
	public void Jump()
    {
		if (canJumped)
		{
			canJumped = false;
			float jumpStrength = MovementData.jumpStrength;
			if (RB.velocity.y < 0f)
			{
				RB.velocity = Vector2.zero;
			}
			RB.AddForce(Vector2.up * jumpStrength, ForceMode2D.Impulse);
		}
	}
	public void Crouch()
    {
		print("crouching");
    }
	public void Dash(Vector2 Input)
    {
		//give dash a cooldown
		print("dashing");
    }
	public void ReleasedKey()
    {
		if (Decelaration == false)
		{
			float currentVelocity = RB.velocity.x;
			float targetVelocity = 0f;
			float t = Mathf.Clamp01(Time.deltaTime / 0.25f);

			float newVelocity = Mathf.Lerp(currentVelocity, targetVelocity, t);
			RB.velocity = new Vector2(newVelocity, RB.velocity.y);
		}
    }
    public void GroundCheck(bool value)
    {
		canJumped = value;
    }
}