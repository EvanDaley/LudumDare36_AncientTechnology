using UnityEngine;
using System.Collections;

[RequireComponent(typeof(NPCTargeting))]
[RequireComponent(typeof(Tag))]
public class NPC : MonoBehaviour {

	[HideInInspector]
	public NPCTargeting NPCTargeting;
	[HideInInspector]
	public NPCHealth NPCHealth;
	[HideInInspector]
	public NPCMovement NPCMovement;

	[HideInInspector]
	public Rigidbody rbody;
	[HideInInspector]
	public Tag myTag;


	void Awake () 
	{
		NPCTargeting = GetComponent < NPCTargeting > ();
		myTag = GetComponent < Tag > ();
		NPCHealth = GetComponent < NPCHealth >();
	}
}
