using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {

	public Text fscore;
	public Text flives;
	public Text FinalScore;
	private int lives_count = 0;
	private int score_count = 0;
	private int final_score_count = 0;

	void Start () {
		if (ScreenScript.pista == 1) {
			lives_count = ScreenScript.lives;
			score_count = ScreenScript.score;
			if (ScreenScript.lives > 0 && ScreenScript.score > 0) {
				final_score_count = score_count + (lives_count * 200);
			}else{
				final_score_count = 0;
			}
			fscore.text = "Score: " + score_count.ToString ();
			flives.text = "Lives: " + lives_count.ToString () + " x 200";
			FinalScore.text = "Final Score: " + final_score_count.ToString ();
		} else if (ScreenScript.pista == 2) {
			lives_count = Screen2Script.lives;
			score_count = Screen2Script.score;
			if (Screen2Script.lives > 0 && Screen2Script.score > 0) {
				final_score_count = score_count + (lives_count * 200);
			} else {
				final_score_count = 0;
			}
			fscore.text = "Score: " + score_count.ToString ();
			flives.text = "Lives: " + lives_count.ToString () + " x 200";
			FinalScore.text = "FinalScore: " + final_score_count.ToString ();
		}
	}
		
}
