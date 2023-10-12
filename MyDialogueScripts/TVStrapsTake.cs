using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVStrapsTake : MonoBehaviour {

	public UnityEngine.UI.Text TVStrapsTakeMessage;
	public bool entrance;
	public float fadeSpeed = 5f;
	public GameObject houseCanvasTVStrapsTake;

	void Awake () 

	{
		TVStrapsTakeMessage = houseCanvasTVStrapsTake.GetComponentInChildren<UnityEngine.UI.Text> ();
		TVStrapsTakeMessage.color = Color.clear;
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
			TVStrapsTakeMessage.color = Color.Lerp (TVStrapsTakeMessage.color, Color.white, fadeSpeed * Time.deltaTime);

		}

		if (!entrance)
		{
			TVStrapsTakeMessage.color = Color.Lerp (TVStrapsTakeMessage.color, Color.clear, fadeSpeed * Time.deltaTime);
		}

	}
}
