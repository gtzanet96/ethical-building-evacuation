using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewDoorScript : MonoBehaviour {

	public float smooth = 2.0f;
	public float DoorOpenAngle = 90.0f;
	private bool open;
	private bool enter;
	private bool doorpls = false;
	private AudioSource myAudio;
	private Vector3 defaultRot;
	private Vector3 openRot;
	[SerializeField]
	private float delayBeforeLoading = 2f;
	private float TimeElapsed;
	[SerializeField]
	private string sceneNameToLoad;

	void Start(){
		defaultRot = transform.eulerAngles;
		openRot = new Vector3 (defaultRot.x, defaultRot.y + DoorOpenAngle, defaultRot.z);
		myAudio = GetComponent<AudioSource>();
	}

	void Update(){
		if(open){
			//Open door
			doorpls = true;
			transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, openRot, Time.deltaTime * smooth);
		}else{
			//Close door
			transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, defaultRot, Time.deltaTime * smooth);
		}

		if(Input.GetKeyDown("f") && enter){
			open = !open;
			myAudio.Play();
		}

		if (doorpls == true) {
			if (ScreenScript.pista == 1) {
				ScreenScript.playing1 = false;
				TimeElapsed += Time.deltaTime;
				if (TimeElapsed > delayBeforeLoading) {
					SceneManager.LoadScene (sceneNameToLoad);
					Cursor.visible = true;
				}
			} else if (ScreenScript.pista == 2) {
				Screen2Script.playing2 = false;
				TimeElapsed += Time.deltaTime;
				if (TimeElapsed > delayBeforeLoading) {
					SceneManager.LoadScene (sceneNameToLoad);
					Cursor.visible = true;
				}
			}
		}
	}

	public void OnGUI(){
		if(enter){
			GUI.Label(new Rect(Screen.width/2 - 75, Screen.height - 100, 250, 50), "Press 'F' to open or close the door");
		}
	}

	public void OnTriggerEnter (Collider other){
		if (other.gameObject.tag == "Player") {
			enter = true;
		}
	}
	public void OnTriggerExit (Collider other){
		if (other.gameObject.tag == "Player") {
			enter = false;
		}
	}
}
