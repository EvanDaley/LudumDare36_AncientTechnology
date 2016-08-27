using UnityEngine;
using System.Collections;

public class PlayerMovement : Player {

	public float moveSpeed = 4f;
	public int totalNumJumps = 1;
	private int jumpsRemaining;
	public float jumpForce = 50;

	// Update is called once per frame
	void Update () 
	{
		// lateral movement
		float horSpeed = Input.GetAxis ("Horizontal");
		float verSpeed = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (horSpeed, 0, verSpeed);
		transform.position = Vector3.MoveTowards (transform.position, transform.position + movement, Time.deltaTime * moveSpeed);
	
		// jumping
		if (Input.GetButtonDown ("Jump"))
			TryJump();
	}

	void TryJump()
	{
		// if we are grounded reset the jump count
		if (IsGrounded)
			jumpsRemaining = totalNumJumps;

		// if not grounded, use jumps remaining
		if (jumpsRemaining > 0)
		{
			jumpsRemaining--;
			Jump ();
		} 
	}

	void Jump()
	{
		rbody.AddForce (Vector3.up * jumpForce);
	}
}
