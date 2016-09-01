using UnityEngine;
using System.Collections;

public interface IHealth 
{
	int Health { get; set; }

	void Damage(int damage);
}
