using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVStrapsDestroy : MonoBehaviour {

	public GameObject str1a;
	public GameObject str1b;
	public GameObject str1c;
	public GameObject str2a;
	public GameObject str2b;
	public GameObject str2c;
	private bool enter;

	void Update(){
		if (enter) {
			if (Input.GetKeyDown ("f")) {
				Destroy (str1a, 1f);
				Destroy (str1b, 1f);
				Destroy (str1c, 1f);
				Destroy (str2a, 1f);
				Destroy (str2b, 1f);
				Destroy (str2c, 1f);
				NewDialogue.StrapsTaken = true;
				Destroy (gameObject, 2f);
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
		if (enter) {
			GUI.Label (new Rect (Screen.width / 2 - 75, Screen.height - 200, 500, 100), "Press 'F' to get the straps!");
		}
	}

}