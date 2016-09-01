using UnityEngine;
using System.Collections;

public class PlayerHealth : Player, IHealth 
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
	}

}
