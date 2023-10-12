using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rafia : MonoBehaviour {

	public UnityEngine.UI.Text RafiaMessage;
	public bool entrance;
	public float fadeSpeed = 5f;
	public GameObject houseCanvasRafia;

	void Awake () 

	{
		RafiaMessage = houseCanvasRafia.GetComponentInChildren<UnityEngine.UI.Text> ();
		RafiaMessage.color = Color.clear;
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

		} 

	}

	void ColorChange () 

	{

		if (entrance)
		{
			RafiaMessage.color = Color.Lerp (RafiaMessage.color, Color.white, fadeSpeed * Time.deltaTime);

		}

		if (!entrance)
		{
			RafiaMessage.color = Color.Lerp (RafiaMessage.color, Color.clear, fadeSpeed * Time.deltaTime);
		}

	}
}
