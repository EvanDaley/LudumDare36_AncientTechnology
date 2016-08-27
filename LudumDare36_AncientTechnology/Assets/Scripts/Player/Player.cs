using UnityEngine;
using System.Collections;

[RequireComponent(typeof(PlayerTargeting))]
[RequireComponent(typeof(PlayerRotation))]
[RequireComponent(typeof(PlayerMovement))]
[RequireComponent(typeof(PlayerBouncing))]
[RequireComponent(typeof(PlayerHands))]
public class Player : MonoBehaviour {

	[HideInInspector]
	public PlayerTargeting PlayerTargeting;
	[HideInInspector]
	public PlayerRotation PlayerRotation;
	[HideInInspector]
	public PlayerMovement PlayerMovement;
	[HideInInspector]
	public Rigidbody rbody;

	private float distToGround;

	void Awake () 
	{
		PlayerTargeting = GetComponent < PlayerTargeting > ();
		PlayerRotation = GetComponent < PlayerRotation > ();
		PlayerMovement = GetComponent < PlayerMovement > ();

		rbody = GetComponent< Rigidbody > ();
		Collider collider = GetComponent< Collider > ();
		distToGround = collider.bounds.extents.y;
	}

	public bool IsGrounded
	{
		get 
		{
			// calculate if the player is on the ground
			return Physics.Raycast(transform.position + Vector3.up*.2f, -Vector3.up, distToGround + .35f);
		}
	}
}
