using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trapezaria : MonoBehaviour {

	public UnityEngine.UI.Text TrapezMessage;
	public bool entrance;
	public float fadeSpeed = 5f;
	public GameObject houseCanvasTrapez;
	public CameraShake cameraShake;

	void Awake () 

	{
		TrapezMessage = houseCanvasTrapez.GetComponentInChildren<UnityEngine.UI.Text> ();
		TrapezMessage.color = Color.clear;
	}

	void Update () 

	{
		ColorChange();
	}


	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			cameraShake.shouldShake = true;
			entrance = true;
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
			TrapezMessage.color = Color.Lerp (TrapezMessage.color, Color.white, fadeSpeed * Time.deltaTime);

		}

		if (!entrance)
		{
			TrapezMessage.color = Color.Lerp (TrapezMessage.color, Color.clear, fadeSpeed * Time.deltaTime);
		}

	}
}
