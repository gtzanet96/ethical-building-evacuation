using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVQuestion : MonoBehaviour {

	public UnityEngine.UI.Text TrapMessage1;
	public bool entrance;
	public float fadeSpeed = 5f;
	public GameObject houseCanvasTV;

	void Awake () 

	{
		TrapMessage1 = houseCanvasTV.GetComponentInChildren<UnityEngine.UI.Text> ();
		TrapMessage1.color = Color.clear;
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
			TrapMessage1.color = Color.Lerp (TrapMessage1.color, Color.white, fadeSpeed * Time.deltaTime);

		}

		if (!entrance)
		{
			TrapMessage1.color = Color.Lerp (TrapMessage1.color, Color.clear, fadeSpeed * Time.deltaTime);
		}

	}
}
