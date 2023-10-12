using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DuckSaveScript : MonoBehaviour {

	private bool enter;

	void Update(){
		if (enter) {
			if (Input.GetKeyDown ("f")) {
				NewDialogue.duckSaved = true;
				Destroy (gameObject, 0.5f);
			}
		}
	}
	public void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "Player" && MissionDuckScript.missionStart == true)
		{
			enter = true;
		} 
	}

	public void OnTriggerExit (Collider other){
		if (other.gameObject.tag == "Player") {
			enter = false;
		}
	}

	public void OnGUI(){
		if (enter) {
			GUI.Label (new Rect (Screen.width / 2 - 75, Screen.height - 200, 500, 100), "Press 'F' to get the duck!");
		}
	}
}
