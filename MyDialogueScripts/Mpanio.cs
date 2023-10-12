using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mpanio : MonoBehaviour {

	public UnityEngine.UI.Text MpanioMessage;
	public bool entrance;
	public float fadeSpeed = 5f;
	public GameObject houseCanvasMpanio;

	void Awake () 

	{
		MpanioMessage = houseCanvasMpanio.GetComponentInChildren<UnityEngine.UI.Text> ();
		MpanioMessage.color = Color.clear;
	}

	void Update () 

	{
		ColorChange();
	}


	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			if (NewDialogue.route1 == false && NewDialogue.route2 == false) {
				entrance = true;
			}else {
				Destroy (gameObject,3f);
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
			MpanioMessage.color = Color.Lerp (MpanioMessage.color, Color.white, fadeSpeed * Time.deltaTime);

		}

		if (!entrance)
		{
			MpanioMessage.color = Color.Lerp (MpanioMessage.color, Color.clear, fadeSpeed * Time.deltaTime);
		}

	}
}
