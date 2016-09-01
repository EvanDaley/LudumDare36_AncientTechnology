using UnityEngine;
using System.Collections;

public class KillTracker : MonoBehaviour {

	public static KillTracker Instance;
	public string[] deathTexts;
	public GameObject DeathText;

	private float killResetCooldown;
	public float killResetInterval = 1.5f;
	private int streak;

	public int Streak
	{
		get 
		{
			return streak;
		}
	}

	void IncrementStreak()
	{
		if (Time.time > killResetCooldown)
			streak = 0;

		killResetCooldown = Time.time + killResetInterval;

		streak ++;
	}

	void Awake () 
	{
		Instance = this;
	}

	public void CreateDeathText(Vector3 pos)
	{
		IncrementStreak ();

		GameObject text = GameObject.Instantiate (DeathText, pos + Vector3.up * 2, Quaternion.identity) as GameObject;
		TextMesh mesh = text.GetComponent<TextMesh> ();

		string deathText;
		if (Streak > deathTexts.Length)
			deathText = (Streak - 1).ToString();
		else
			deathText = deathTexts [Streak - 1];
		
		mesh.text = deathText;
	}
}
