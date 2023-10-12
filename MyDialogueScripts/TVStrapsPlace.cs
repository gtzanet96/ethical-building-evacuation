using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVStrapsPlace : MonoBehaviour {

	public UnityEngine.UI.Text TVStrapsPlaceMessage;
	public bool entrance;
	public float fadeSpeed = 5f;
	public GameObject houseCanvasTVStrapsPlace;

	void Awake () 

	{
		TVStrapsPlaceMessage = houseCanvasTVStrapsPlace.GetComponentInChildren<UnityEngine.UI.Text> ();
		TVStrapsPlaceMessage.color = Color.clear;
	}

	void Update () 

	{
		ColorChange();
	}


	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "Player" && NewDialogue.StrapsTaken == true)
		{
			entrance = true;
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
			TVStrapsPlaceMessage.color = Color.Lerp (TVStrapsPlaceMessage.color, Color.white, fadeSpeed * Time.deltaTime);

		}

		if (!entrance)
		{
			TVStrapsPlaceMessage.color = Color.Lerp (TVStrapsPlaceMessage.color, Color.clear, fadeSpeed * Time.deltaTime);
		}

	}
}
