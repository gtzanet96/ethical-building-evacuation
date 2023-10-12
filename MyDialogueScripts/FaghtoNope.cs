using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaghtoNope : MonoBehaviour {

	public UnityEngine.UI.Text FaghtoNopeMessage;
	public bool entrance;
	public float fadeSpeed = 5f;
	public GameObject houseCanvasFaghtoNope;

	void Awake () 

	{
		FaghtoNopeMessage = houseCanvasFaghtoNope.GetComponentInChildren<UnityEngine.UI.Text> ();
		FaghtoNopeMessage.color = Color.clear;
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
			Destroy (gameObject,0.3f);
		} 

	}

	void ColorChange () 

	{

		if (entrance)
		{
			FaghtoNopeMessage.color = Color.Lerp (FaghtoNopeMessage.color, Color.white, fadeSpeed * Time.deltaTime);

		}

		if (!entrance)
		{
			FaghtoNopeMessage.color = Color.Lerp (FaghtoNopeMessage.color, Color.clear, fadeSpeed * Time.deltaTime);
		}

	}
}
