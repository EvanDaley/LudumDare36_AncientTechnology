using UnityEngine;
using System.Collections;

public class AddForceOnSpawn : MonoBehaviour {

	public Vector3 direction;
	private Rigidbody rbody;
	public float moveForce;

	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody> ();
		if (direction == Vector3.zero)
			direction = transform.forward;

		rbody.AddForce (direction * moveForce);
	}

}
