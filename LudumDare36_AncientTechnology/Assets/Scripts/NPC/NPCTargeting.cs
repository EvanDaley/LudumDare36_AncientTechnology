using UnityEngine;
using System.Collections;

public class NPCTargeting : NPC {

	private Vector3 targetPosition;
	private Transform targetTransform;
	private Tag targetTag;

	public float targetSwitchInterval = 1f; // the amount of time we follow an enemy before checking if there is a closer target
	private float targetSwitchCooldown;

	public Vector3 TargetPosition
	{
		get
		{ 
			return targetPosition;
		}

		set
		{ 
			targetPosition = value;
		}
	}

	public Transform TargetTransform
	{
		get
		{ 
			return targetTransform;
		}

		set
		{ 
			targetTransform = value;
		}
	}

	public Tag TargetTag
	{
		get
		{ 
			return targetTag;
		}

		set
		{ 
			targetTag = value;
		}
	}

	void Update () 
	{
		if (Time.time > targetSwitchCooldown)
		{
			UpdateTarget ();
		}
	}

	void UpdateTarget()
	{
		targetSwitchCooldown = Time.time + targetSwitchInterval;

		Tag target = TagTracker.Instance.GetClosestEnemy (myTag);

		if (target != null)
		{
			TargetPosition = target.transform.position;
			TargetTag = target;
			TargetTransform = target.transform;
		}
	}
}
