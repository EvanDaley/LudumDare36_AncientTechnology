using UnityEngine;
using System.Collections;

public class PlayerHands : Player {

	public Transform RHand;
	public Transform RItem;

	public Transform LHand;
	public Transform LItem;

	void Start () 
	{
	
	}
	
	void Update () 
	{
		RHand.LookAt (PlayerTargeting.TargetPosition);
		LHand.LookAt (PlayerTargeting.TargetPosition);

	}
}
