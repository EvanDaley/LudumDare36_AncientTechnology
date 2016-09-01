using UnityEngine;
using System.Collections;

public class PseudoRandom : MonoBehaviour {

	public static PseudoRandom Instance;
	private int count = 0; 

	void Awake()
	{
		Instance = this;
	}

	public bool SequenceMod(int chance)
	{
		count++;
		if (count % chance == 0)
		{
			return true;
		}

		return false;
	}

}
