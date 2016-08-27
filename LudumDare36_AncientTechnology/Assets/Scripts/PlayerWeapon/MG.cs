using UnityEngine;
using System.Collections;

public class MG : MonoBehaviour {

	public Transform muzzle;
	public GameObject bulletPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButton ("Fire1"))
		{
			GameObject bullet = GameObject.Instantiate (bulletPrefab, muzzle.position + (Random.onUnitSphere * .1f), muzzle.rotation) as GameObject;
		}
	}
}
