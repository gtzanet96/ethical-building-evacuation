using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapezReal2 : MonoBehaviour {

	public UnityEngine.UI.Text TrapezReal2Message;
	public bool entrance;
	public float fadeSpeed = 5f;
	public GameObject houseCanvasTrapezReal2;
	public CameraShake cameraShake;

	void Awake () 

	{
		TrapezReal2Message = houseCanvasTrapezReal2.GetComponentInChildren<UnityEngine.UI.Text> ();
		TrapezReal2Message.color = Color.clear;

	}

	void Update () 

	{
		ColorChange();
	}


	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			NewDialogue.route2 = true;
			if (NewDialogue.route2 == true && NewDialogue.route1 == false) {
				cameraShake.shouldShake = true;
				entrance = true;
			} else {
				Destroy (gameObject,3f);
				NewDialogue.route2 = false;
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
			TrapezReal2Message.color = Color.Lerp (TrapezReal2Message.color, Color.white, fadeSpeed * Time.deltaTime);

		}

		if (!entrance)
		{
			TrapezReal2Message.color = Color.Lerp (TrapezReal2Message.color, Color.clear, fadeSpeed * Time.deltaTime);
		}

	}
}
