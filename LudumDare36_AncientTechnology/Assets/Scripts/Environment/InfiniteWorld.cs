using UnityEngine;
using System.Collections;

public class InfiniteWorld : MonoBehaviour {

	public GameObject player;
	public GameObject[] grassPrefabs;
	private int count;

	void Start () 
	{
		for (int i = -1; i < 2; i++)
		{
			for (int j = -1; j < 2; j++)
			{
				GameObject tile = GameObject.Instantiate (grassPrefabs [count % grassPrefabs.Length], new Vector3(i * 16, 0, j*16), Quaternion.identity) as GameObject;
			}
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
