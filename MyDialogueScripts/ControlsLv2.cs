using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsLv2 : MonoBehaviour {

	public UnityEngine.UI.Text ControlsMessage;
	public bool entrance;
	public float fadeSpeed = 5f;
	public GameObject houseCanvasControls;

	void Awake () 

	{
		ControlsMessage = houseCanvasControls.GetComponentInChildren<UnityEngine.UI.Text> ();
		ControlsMessage.color = Color.clear;
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

		} 

	}

	void ColorChange () 

	{

		if (entrance)
		{
			ControlsMessage.color = Color.Lerp (ControlsMessage.color, Color.white, fadeSpeed * Time.deltaTime);

		}

		if (!entrance)
		{
			ControlsMessage.color = Color.Lerp (ControlsMessage.color, Color.clear, fadeSpeed * Time.deltaTime);
		}

	}
}
