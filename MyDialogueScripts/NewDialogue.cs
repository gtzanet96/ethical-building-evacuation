using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewDialogue : MonoBehaviour {

	public UnityEngine.UI.Text FirstMessage;
	public bool entrance;
	public float fadeSpeed = 5f;
	public GameObject houseCanvas;
	public CameraShake cameraShake;
	public static bool duckSaved = false;
	public static bool StrapsTaken = false;
	public static bool route1 = false;
	public static bool route2 = false;

	void Awake () 

	{
		FirstMessage = houseCanvas.GetComponentInChildren<UnityEngine.UI.Text> ();
		FirstMessage.color = Color.clear;
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
			FirstMessage.color = Color.Lerp (FirstMessage.color, Color.white, fadeSpeed * Time.deltaTime);

		}

		if (!entrance)
		{
			FirstMessage.color = Color.Lerp (FirstMessage.color, Color.clear, fadeSpeed * Time.deltaTime);
		}

	}

}
