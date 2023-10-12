using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PapiaDialogueScript : MonoBehaviour {

	public UnityEngine.UI.Text RoloiMessage;
	public bool entrance;
	public float fadeSpeed = 5f;
	public GameObject houseCanvasRoloi;

	void Awake () 

	{
		RoloiMessage = houseCanvasRoloi.GetComponentInChildren<UnityEngine.UI.Text> ();
		RoloiMessage.color = Color.clear;
	}

	void Update () 

	{
		ColorChange();
	}


	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			entrance = true;
			AudioSource audio = GetComponent<AudioSource>();
			audio.Play();
		} 

	}

	void OnTriggerExit (Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			entrance = false;                       
			Destroy (gameObject,3f);
		} 

	}

	void ColorChange () 

	{

		if (entrance)
		{
			RoloiMessage.color = Color.Lerp (RoloiMessage.color, Color.white, fadeSpeed * Time.deltaTime);

		}

		if (!entrance)
		{
			RoloiMessage.color = Color.Lerp (RoloiMessage.color, Color.clear, fadeSpeed * Time.deltaTime);
		}

	}
}
