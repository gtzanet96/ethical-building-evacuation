using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farma2 : MonoBehaviour {

	public UnityEngine.UI.Text Farma2Message;
	public bool entrance;
	public float fadeSpeed = 5f;
	public GameObject houseCanvasFarma2;

	void Awake () 

	{
		Farma2Message = houseCanvasFarma2.GetComponentInChildren<UnityEngine.UI.Text> ();
		Farma2Message.color = Color.clear;
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
			Farma2Message.color = Color.Lerp (Farma2Message.color, Color.white, fadeSpeed * Time.deltaTime);

		}

		if (!entrance)
		{
			Farma2Message.color = Color.Lerp (Farma2Message.color, Color.clear, fadeSpeed * Time.deltaTime);
		}

	}
}
