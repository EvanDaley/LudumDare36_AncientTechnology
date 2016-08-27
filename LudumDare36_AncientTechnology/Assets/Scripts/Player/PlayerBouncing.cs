using UnityEngine;
using System.Collections;

public class PlayerBouncing : Player {

	void Start () 
	{
		
	}
	
	void Update () 
	{
		float horSpeed = Input.GetAxis ("Horizontal");
		float verSpeed = Input.GetAxis ("Vertical");

		print (base.IsGrounded);
	}
}
