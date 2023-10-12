using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadOnEnter : StateMachineBehaviour {

	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) 
	{
		if (Application.loadedLevelName.Equals("MainMenu")){
			SceneManager.LoadScene (5);
		}
		if (Application.loadedLevelName.Equals("VictoryScreen") || Application.loadedLevelName.Equals("GameOverScreen")){
			if (ScreenScript.pista == 1){
				SceneManager.LoadScene (1);
			}else if(ScreenScript.pista ==2){
				SceneManager.LoadScene (4);
			}
		}
	}
}
					