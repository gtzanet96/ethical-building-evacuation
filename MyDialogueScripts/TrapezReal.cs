using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapezReal : MonoBehaviour {

	public UnityEngine.UI.Text TrapezRealMessage;
	public bool entrance;
	public float fadeSpeed = 5f;
	public GameObject houseCanvasTrapezReal;
	public CameraShake cameraShake;

	void Awake () 

	{
		TrapezRealMessage = houseCanvasTrapezReal.GetComponentInChildren<UnityEngine.UI.Text> ();
		TrapezRealMessage.color = Color.clear;
	}

	void Update () 

	{
		ColorChange();
	}


	void OnTriggerEnter (Collider col)
	{
		
		if (col.gameObject.tag == "Player")
		{
			NewDialogue.route1 = true;
			if (NewDialogue.route1 == true && NewDialogue.route2 == false) {
				cameraShake.shouldShake = true;
				entrance = true;
			} else {
				Destroy (gameObject,3f);
				NewDialogue.route1 = false;
			}
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
			TrapezRealMessage.color = Color.Lerp (TrapezRealMessage.color, Color.white, fadeSpeed * Time.deltaTime);
		}

		if (!entrance)
		{
			TrapezRealMessage.color = Color.Lerp (TrapezRealMessage.color, Color.clear, fadeSpeed * Time.deltaTime);
		}

	}
}
