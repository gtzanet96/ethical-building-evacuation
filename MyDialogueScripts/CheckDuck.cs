using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDuck : MonoBehaviour {

	public UnityEngine.UI.Text CheckDuckFMessage;
	public UnityEngine.UI.Text CheckDuckSMessage;
	public bool entrance1;
	public bool entrance2;
	public float fadeSpeed = 5f;
	public GameObject houseCanvasCheckDuckF;
	public GameObject houseCanvasCheckDuckS; 

	void Awake () 
	{
			CheckDuckSMessage = houseCanvasCheckDuckS.GetComponentInChildren<UnityEngine.UI.Text> ();
			CheckDuckSMessage.color = Color.clear;
			CheckDuckFMessage = houseCanvasCheckDuckF.GetComponentInChildren<UnityEngine.UI.Text> ();
			CheckDuckFMessage.color = Color.clear;
	}

	void Update () 
	{
		ColorChange();
	}


	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "Player")
		{	
			if (NewDialogue.duckSaved == true) {
				entrance1 = true;
				Screen2Script.score = Screen2Script.score + 300;
			}
			else if (NewDialogue.duckSaved == false) {
				Screen2Script.score = Screen2Script.score - 300;
				gameObject.tag = "Pagida1";
				entrance2 = true;
				AudioSource audio = GetComponent<AudioSource>();
				audio.Play();

			}
		} 

	}

	void OnTriggerExit (Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			if (NewDialogue.duckSaved == true) {
				entrance1 = false;  
			} 
			else if (NewDialogue.duckSaved == false) {
				entrance2 = false;
			}
			Destroy (gameObject, 0.5f);
		} 

	}

	void ColorChange ()
	{
		if (NewDialogue.duckSaved == true) {
			if (entrance1) {
				CheckDuckSMessage.color = Color.Lerp (CheckDuckSMessage.color, Color.white, fadeSpeed * Time.deltaTime);

			}

			if (!entrance1) {
				CheckDuckSMessage.color = Color.Lerp (CheckDuckSMessage.color, Color.clear, fadeSpeed * Time.deltaTime);
			}
		} else if (NewDialogue.duckSaved == false) {
			if (entrance2) {
				CheckDuckFMessage.color = Color.Lerp (CheckDuckFMessage.color, Color.white, fadeSpeed * Time.deltaTime);
			}

			if (!entrance2) {
				CheckDuckFMessage.color = Color.Lerp (CheckDuckFMessage.color, Color.clear, fadeSpeed * Time.deltaTime);
			}
		}
	}
}
