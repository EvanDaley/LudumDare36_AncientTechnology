using UnityEngine;
using System.Collections;

public class PlayerRotation : Player {


	void Start()
	{

	}

	void Update ()
	{
		Vector3 targetPoint = PlayerTargeting.TargetPosition;
		targetPoint.y = transform.position.y;
		transform.LookAt (targetPoint);
	}
}
