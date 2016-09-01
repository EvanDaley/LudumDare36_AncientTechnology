using UnityEngine;
using System.Collections;

public class NPCHealth : NPC, IHealth 
{
	public int health = 100;
	public int Health 
	{ 
		get 
		{
			return health;
		}
		set
		{ 
			health = value;
		}
	}

	public void Damage(int damage)
	{
		health -= damage;

		if (health < 1)
			Die ();
	}

	public void Die()
	{
		KillTracker.Instance.CreateDeathText (transform.position);
	}
}
