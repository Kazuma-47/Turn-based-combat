using UnityEngine;
public class Movement : MonoBehaviour
{
	[Header("Input Map")]
	public Rigidbody2D RB;
	private Vector2 _moveInput;
	
	public bool hasJumped;
	public MovementSettings MovementData;

	private void Awake()
	{
		RB = GetComponent<Rigidbody2D>();	
	}
   

	
    private void Run(float lerpAmount)
	{
		float targetSpeed = _moveInput.x * MovementData.maxRunSpeed;
		targetSpeed = Mathf.Lerp(RB.velocity.x, targetSpeed, lerpAmount);
		float accelRate;

		accelRate = (Mathf.Abs(targetSpeed) > 0.01f) ? MovementData.runAccelAmount : MovementData.runDeccelAmount;

		float speedDif = targetSpeed - RB.velocity.x;

		float movement = accelRate * speedDif;
		RB.AddForce(movement * Vector2.right, ForceMode2D.Force);
	}
	private void Jump()
    {
		if (!hasJumped)
		{
			hasJumped = false;
			float jumpStrength = MovementData.jumpStrength;
			if (RB.velocity.y < 0f)
			{
				RB.velocity = Vector2.zero;
			}
			RB.AddForce(Vector2.up * jumpStrength, ForceMode2D.Impulse);
		}
	}
}