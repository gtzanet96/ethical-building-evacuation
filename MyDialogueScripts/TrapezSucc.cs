using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapezSucc : MonoBehaviour {

	public UnityEngine.UI.Text TrapezSuccMessage;
	public UnityEngine.UI.Text TrapezSuccMessage2;
	public bool entrance;
	public float fadeSpeed = 5f;
	public GameObject houseCanvasTrapezSucc;
	public GameObject houseCanvasTrapezSucc2;

	void Awake () 

	{
		TrapezSuccMessage = houseCanvasTrapezSucc.GetComponentInChildren<UnityEngine.UI.Text> ();
		TrapezSuccMessage.color = Color.clear;
		TrapezSuccMessage2 = houseCanvasTrapezSucc2.GetComponentInChildren<UnityEngine.UI.Text> ();
		TrapezSuccMessage2.color = Color.clear;
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
			Screen2Script.score = Screen2Script.score + 400;
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
			TrapezSuccMessage.color = Color.Lerp (TrapezSuccMessage.color, Color.white, fadeSpeed * Time.deltaTime);
			TrapezSuccMessage2.color = Color.Lerp (TrapezSuccMessage2.color, Color.white, fadeSpeed * Time.deltaTime);

		}

		if (!entrance)
		{
			TrapezSuccMessage.color = Color.Lerp (TrapezSuccMessage.color, Color.clear, fadeSpeed * Time.deltaTime);
			TrapezSuccMessage2.color = Color.Lerp (TrapezSuccMessage2.color, Color.clear, fadeSpeed * Time.deltaTime);
		}

	}
}