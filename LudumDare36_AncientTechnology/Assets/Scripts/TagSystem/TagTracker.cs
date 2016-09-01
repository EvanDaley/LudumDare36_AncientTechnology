using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TagTracker : MonoBehaviour {

	public static TagTracker Instance;

	List<Tag> actors = new List<Tag>();

	void Awake()
	{
		Instance = this;
	}

	// important methods
	public void RegisterActor(Tag tag)
	{
		actors.Add (tag);
	}

	public void DeRegisterActor(Tag tag)
	{
		actors.Remove (tag);
	}

	public Tag GetClosestEnemy(Tag myTag)
	{
		return GetClosestEnemy (myTag.transform.position, myTag.teamNumber);
	}

	public Tag GetClosestEnemy(Vector3 position, int teamId)
	{
		float curDist = 0;
		float minDistance = float.MaxValue;
		Tag closestEnemy = null;

		foreach (Tag tag in actors)
		{
			if (tag != null)
			{
				if (tag.teamNumber != teamId && tag.teamNumber != -1)
				{
					curDist = Vector3.Distance (position, tag.transform.position);
					if (curDist < minDistance)
					{
						minDistance = curDist;
						closestEnemy = tag;

						if (curDist < 2)
							return closestEnemy;
					}
				}
			}
		}

		return closestEnemy;
	}
		
	// other cool methods
	public void ActivatePlayersOnTeam(int team)
	{
		foreach (Tag tag in actors)
		{
			if (tag != null)
			{
				if (tag.teamNumber == team)
				{
					tag.gameObject.SetActive (true);

					//Health health = tag.GetComponent<Health> ();
					//health.Invoke ("InitializeHealth", .1f);
				}
			}
		}
	}

	public void DestroyPlayersOnTeam(int team)
	{
		foreach (Tag tag in actors)
		{
			if (tag != null)
			{
				if (tag.teamNumber == team && tag.teamNumber != -1)
				{
					Destroy (tag.gameObject);
				}
			}
		}
	}

	public void DestroyAllPlayersNotOnTeam(int team)
	{
		foreach (Tag tag in actors)
		{
			if (tag != null)
			{
				if (tag.teamNumber != team && tag.teamNumber != -1)
				{
					Destroy (tag.gameObject);
				}
			}
		}
	}

	public int GetNumPlayersOnTeam(int team)
	{
		int count = 0;
		foreach (Tag tag in actors)
		{
			if (tag != null)
			{
				if (tag.teamNumber == team)
				{
					if(tag.gameObject.activeSelf)
						count++;
				}
			}
		}

		return count;
	}
}
