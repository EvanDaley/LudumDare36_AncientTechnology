using UnityEngine;
using System.Collections;

public class SplatterBloodOnImpact : MonoBehaviour {

	public GameObject splatterPrefab;

	void OnCollisionEnter(Collision other)
	{
		IHealth health = other.gameObject.GetComponent<IHealth> ();
		if (health != null)
		{
			if (health.Health < 1)
				return;

			//if (!PseudoRandom.Instance.SequenceMod (8))
			//	return;

			health.Damage (10);

			GameObject splatterInstance = GameObject.Instantiate (splatterPrefab, transform.position, transform.rotation) as GameObject;
		}
	}
}
