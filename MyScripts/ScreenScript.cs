using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenScript : MonoBehaviour {

	public Text zwes;
	public Text pontoi;

	public static int score = 1000;
	public static int lives = 3;
	public static int pista = 1;
	public static bool playing1 = true;

	private void Start () {
		score = 1000;
		lives = 3;
		playing1 = true;
		pista = 1;
		StartCoroutine (decreaseScore());
	}


	private void Update () {

	}

	IEnumerator decreaseScore(){
		while (score > 0 && playing1 == true) {
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
