using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Screen2Script : MonoBehaviour {

	public Text zwes;
	public Text pontoi;

	public static int score = 4000;
	public static int lives = 5;
	public static bool playing2 = true;

	public void Start () {
		score = 4000;
		lives = 5;
		playing2 = true;
		ScreenScript.pista = 2;
		StartCoroutine (decreaseScore());
	}


	void Update () {

	}

	IEnumerator decreaseScore(){
		while (score > 0 && playing2 == true) {
			score -= 1;
			pontoi.text = "Score:" + score.ToString ();
			yield return new WaitForSeconds (0.1f);
		}
	}

	public void OnTriggerEnter (Collider other){
		if (other.tag == "Pagida1") {
			score = score - 100;
			pontoi.text = "Score:" + (score).ToString ();
			lives = lives - 1;
			zwes.text = "Lives:" + (lives).ToString ();
		}
	}
}
