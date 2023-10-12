using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVStrapsShow : MonoBehaviour {

	public GameObject str3a;
	public GameObject str3b;
	public GameObject str3c;
	public GameObject str4a;
	public GameObject str4b;
	public GameObject str4c;
	private bool enter;

	void Update(){
		if (enter && NewDialogue.StrapsTaken == true) {
			if (Input.GetKeyDown ("f")) {
				str3a.SetActive (true);
				str3b.SetActive (true);
				str3c.SetActive (true);
				str4a.SetActive (true);
				str4b.SetActive (true);
				str4c.SetActive (true);
				Screen2Script.score = Screen2Script.score + 200;
				Destroy (gameObject, 5f);
			}
		} 
	}

	public void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "Player") {
			enter = true;
		}
	}

	public void OnTriggerExit (Collider other){
		if (other.gameObject.tag == "Player") {
			enter = false;
		}
	}

	public void OnGUI(){
		if (enter && NewDialogue.StrapsTaken == true) {
			GUI.Label (new Rect (Screen.width / 2 - 75, Screen.height - 200, 500, 100), "Press 'F' to put the straps!");
		}
	}

}
