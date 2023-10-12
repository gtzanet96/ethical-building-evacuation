using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pista2CommonTrap : MonoBehaviour {


	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "Player") {
			AudioSource audio = GetComponent<AudioSource> ();
			audio.Play ();
		}
	}

	void OnTriggerExit (Collider col)
	{
		if (col.gameObject.tag == "Player")
		{ 
			Destroy (gameObject,1f);
		} 

	}
}
