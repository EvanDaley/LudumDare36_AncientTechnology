using UnityEngine;
using System.Collections;

public class PlayerTargeting : Player {

	public LayerMask targetMask;
	private Vector3 targetPosition;
	private Transform targetTransform;
	private Ray ray;
	private RaycastHit hit;

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

	void Update()
	{
		ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		if (Physics.Raycast (ray, out hit, 100, targetMask))
		{
			TargetTransform = hit.transform;
			TargetPosition = hit.point;

			// testing
			//GameObject primitive = GameObject.CreatePrimitive (PrimitiveType.Cube);
			//primitive.transform.position = hit.point;
		}
	}

}
