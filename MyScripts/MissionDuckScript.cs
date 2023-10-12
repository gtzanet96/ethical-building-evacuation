using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionDuckScript : MonoBehaviour {

	public static bool missionStart = false;

	void Start () {
		
	}
	

	void Update () {
		
	}

	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "Player" && NewDialogue.duckSaved == false)
		{
			missionStart = true;
		} 

	}

}
