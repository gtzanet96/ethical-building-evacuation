using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaKouzinas : MonoBehaviour {

	public UnityEngine.UI.Text SecondMessage;
	public bool entrance;
	public float fadeSpeed = 5f;
	public GameObject houseCanvas3;

	void Awake () 

	{
		SecondMessage = houseCanvas3.GetComponentInChildren<UnityEngine.UI.Text> ();
		SecondMessage.color = Color.clear;
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
			SecondMessage.color = Color.Lerp (SecondMessage.color, Color.white, fadeSpeed * Time.deltaTime);

		}

		if (!entrance)
		{
			SecondMessage.color = Color.Lerp (SecondMessage.color, Color.clear, fadeSpeed * Time.deltaTime);
		}

	}
}
