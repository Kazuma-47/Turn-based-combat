using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Movement Config")]
public class MovementSettings : ScriptableObject
{
	[Header("Movement Config")]
	public float jumpStrength;
    public float maxRunSpeed;
	public float runAcceleration;
	public float runDecceleration;
	[HideInInspector] public float runAccelAmount;
    [HideInInspector] public float runDeccelAmount;

	private void OnValidate()
	{
		runAccelAmount = (50 * runAcceleration) / maxRunSpeed;
		runDeccelAmount = (50 * runDecceleration) / maxRunSpeed;
	
		runAcceleration = Mathf.Clamp(runAcceleration, 0.01f, maxRunSpeed);
		runDecceleration = Mathf.Clamp(runDecceleration, 0.01f, maxRunSpeed);

	}
}
