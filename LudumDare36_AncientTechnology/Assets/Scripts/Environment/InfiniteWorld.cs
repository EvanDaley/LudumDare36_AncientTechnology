using UnityEngine;
using System.Collections;

public class InfiniteWorld : MonoBehaviour {

	public GameObject player;
	public GameObject[] grassPrefabs;
	private int count;

	void Start () 
	{
		for (int i = -3; i < 4; i++)
		{
			for (int j = -3; j < 4; j++)
			{
				GameObject tile = GameObject.Instantiate (grassPrefabs [count % grassPrefabs.Length], new Vector3(i * 16, 0, j*16), Quaternion.identity) as GameObject;
				count++;
			}
		}
	}

	void UpdateMap()
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
