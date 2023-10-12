using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverCondition : MonoBehaviour {

	[SerializeField]
	private float delayBeforeLoading = 3f;
	[SerializeField]
	private string sceneNameToLoad;
	private float TimeElapsed;


	void Update () {
		if (ScreenScript.pista == 1) {
			if (ScreenScript.lives <= 0 || ScreenScript.score <= 0) {
				ScreenScript.playing1 = false;
				TimeElapsed += Time.deltaTime;
				if (TimeElapsed > delayBeforeLoading) {
					SceneManager.LoadScene (sceneNameToLoad);
				}
			}
		}
		if (ScreenScript.pista == 2) {
			if (Screen2Script.lives <= 0 || Screen2Script.score <= 0) {
				Screen2Script.playing2 = false;
				TimeElapsed += Time.deltaTime;
				if (TimeElapsed > delayBeforeLoading) {
					SceneManager.LoadScene (sceneNameToLoad);
				}
			}
		}
	}
}
