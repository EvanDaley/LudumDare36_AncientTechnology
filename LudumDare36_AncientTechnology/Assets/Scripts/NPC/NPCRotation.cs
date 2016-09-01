using UnityEngine;
using System.Collections;

public class NPCRotation : NPC {

	void Update () 
	{
		if (NPCTargeting.TargetTag != null && NPCHealth.Health > 0)
		{
			Vector3 targetPoint = NPCTargeting.TargetTag.transform.position;
			targetPoint.y = transform.position.y;
			transform.LookAt (targetPoint);
		}
	}
}
