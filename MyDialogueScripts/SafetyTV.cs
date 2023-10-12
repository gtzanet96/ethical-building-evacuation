using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafetyTV : MonoBehaviour {

	public UnityEngine.UI.Text SafetyTVMessage;
	public bool entrance;
	public float fadeSpeed = 5f;
	public GameObject houseCanvasSafetyTV;

	void Awake () 

	{
		SafetyTVMessage = houseCanvasSafetyTV.GetComponentInChildren<UnityEngine.UI.Text> ();
		SafetyTVMessage.color = Color.clear;
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
		} 

	}

	void OnTriggerExit (Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			entrance = false;                       
			Destroy (gameObject, 1f);
		} 

	}

	void ColorChange () 

	{

		if (entrance)
		{
			SafetyTVMessage.color = Color.Lerp (SafetyTVMessage.color, Color.white, fadeSpeed * Time.deltaTime);

		}

		if (!entrance)
		{
			SafetyTVMessage.color = Color.Lerp (SafetyTVMessage.color, Color.clear, fadeSpeed * Time.deltaTime);
		}

	}
}
