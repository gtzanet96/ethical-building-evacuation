using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Faghto : MonoBehaviour {

	public UnityEngine.UI.Text FaghtoMessage;
	public bool entrance;
	public float fadeSpeed = 5f;
	public GameObject houseCanvasFaghto;

	void Awake () 

	{
		FaghtoMessage = houseCanvasFaghto.GetComponentInChildren<UnityEngine.UI.Text> ();
		FaghtoMessage.color = Color.clear;
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
			FaghtoMessage.color = Color.Lerp (FaghtoMessage.color, Color.white, fadeSpeed * Time.deltaTime);

		}

		if (!entrance)
		{
			FaghtoMessage.color = Color.Lerp (FaghtoMessage.color, Color.clear, fadeSpeed * Time.deltaTime);
		}

	}
}
