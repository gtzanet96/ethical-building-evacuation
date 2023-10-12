using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mpanio2 : MonoBehaviour {

	public UnityEngine.UI.Text Mpanio2Message;
	public bool entrance;
	public float fadeSpeed = 5f;
	public GameObject houseCanvasMpanio2;

	void Awake () 

	{
		Mpanio2Message = houseCanvasMpanio2.GetComponentInChildren<UnityEngine.UI.Text> ();
		Mpanio2Message.color = Color.clear;
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
			Mpanio2Message.color = Color.Lerp (Mpanio2Message.color, Color.white, fadeSpeed * Time.deltaTime);

		}

		if (!entrance)
		{
			Mpanio2Message.color = Color.Lerp (Mpanio2Message.color, Color.clear, fadeSpeed * Time.deltaTime);
		}

	}
}
