using UnityEngine;
using System.Collections;

public class Tag : MonoBehaviour {

	public int teamNumber;

	void Start()
	{
		TagTracker.Instance.RegisterActor (this);
	}

	void OnDeath()
	{
		TagTracker.Instance.DeRegisterActor (this);
	}
}
