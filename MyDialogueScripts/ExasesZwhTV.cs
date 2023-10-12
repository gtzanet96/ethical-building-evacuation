using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExasesZwhTV : MonoBehaviour {

	public UnityEngine.UI.Text ExasesZwhMessage;
	public bool entrance;
	public float fadeSpeed = 5f;
	public GameObject houseCanvasTV2;

	void Awake () 

	{
		ExasesZwhMessage = houseCanvasTV2.GetComponentInChildren<UnityEngine.UI.Text> ();
		ExasesZwhMessage.color = Color.clear;
	}

	void Update () 

	{
		ColorChange();
	}


	void OnTriggerEnter (Collider col)
	{
		
		if (col.gameObject.tag == "Player") 
		{
			if (ScreenScript.pista == 2) {
				entrance = true;
			} else {
				entrance = true;
				AudioSource audio = GetComponent<AudioSource>();
				audio.Play();
			}
		}
	}

	void OnTriggerExit (Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			if (ScreenScript.pista == 2) {
				entrance = false;   
				Destroy (gameObject, 3f);
			} else {
				entrance = false;
				Destroy (gameObject, 0.3f);
			}
		} 

	}

	void ColorChange () 

	{
		if (entrance)
		{
			ExasesZwhMessage.color = Color.Lerp (ExasesZwhMessage.color, Color.white, fadeSpeed * Time.deltaTime);

		}

		if (!entrance)
		{
			ExasesZwhMessage.color = Color.Lerp (ExasesZwhMessage.color, Color.clear, fadeSpeed * Time.deltaTime);
		}

	}
}