using UnityEngine;
using System.Collections;

public class NPCMovement : NPC {

	public float moveSpeed = 5;

	// Update is called once per frame
	void Update () 
	{
		if (NPCTargeting.TargetTag != null && NPCHealth.Health > 0)
		{
			Vector3 movement = NPCTargeting.TargetTag.transform.position - transform.position;
			transform.position = Vector3.MoveTowards (transform.position, transform.position + movement, Time.deltaTime * moveSpeed);
		}
	}
}
