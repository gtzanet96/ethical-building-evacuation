using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diadromos2 : MonoBehaviour {

	public UnityEngine.UI.Text DiadromosMessage;
	public bool entrance;
	public float fadeSpeed = 5f;
	public GameObject houseCanvas2;

	void Awake () 

	{
		DiadromosMessage = houseCanvas2.GetComponentInChildren<UnityEngine.UI.Text> ();
		DiadromosMessage.color = Color.clear;
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

		} 

	}

	void ColorChange () 

	{

		if (entrance)
		{
			DiadromosMessage.color = Color.Lerp (DiadromosMessage.color, Color.white, fadeSpeed * Time.deltaTime);
		
		}

		if (!entrance)
		{
			DiadromosMessage.color = Color.Lerp (DiadromosMessage.color, Color.clear, fadeSpeed * Time.deltaTime);
		}

	}
}
