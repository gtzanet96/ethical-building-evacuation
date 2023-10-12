using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mpanior2 : MonoBehaviour {

	public UnityEngine.UI.Text Mpanior2Message;
	public bool entrance;
	public float fadeSpeed = 5f;
	public GameObject houseCanvasMpanior2;

	void Awake () 

	{
		Mpanior2Message = houseCanvasMpanior2.GetComponentInChildren<UnityEngine.UI.Text> ();
		Mpanior2Message.color = Color.clear;
	}

	void Update () 

	{
		ColorChange();
	}


	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			if (NewDialogue.route2 == true) {
				if (NewDialogue.route1 == false) {
					entrance = true;
				} else {
					Destroy (gameObject, 3f);
				}
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
			Debug.Log ("mpainei");
			Mpanior2Message.color = Color.Lerp (Mpanior2Message.color, Color.white, fadeSpeed * Time.deltaTime);

		}

		if (!entrance)
		{
			Mpanior2Message.color = Color.Lerp (Mpanior2Message.color, Color.clear, fadeSpeed * Time.deltaTime);
		}

	}
}
