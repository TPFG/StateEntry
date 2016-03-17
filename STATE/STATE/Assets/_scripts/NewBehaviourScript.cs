using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UImanager : MonoBehaviour {

	public GameObject PausePanel;

	public bool isPaused;

	// Use this for initialization
	void Start () {
		isPaused = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(isPaused) {
			PauseGame (true);
		}
		else {
			PauseGame (false);
		}

if (Input.GetKeyDown ("Pause")) {
		SwitchPause ();
}

	}

	void PauseGame (bool state) {
		if(state) {
			Time.timeScale = 0.0f; //paused
		}
		else {
			Time.timeScale = 1.0f; //unpaused
		}
		PausePanel.SetActive (state);
	}

	public void SwitchPause() {
		if(isPaused == true) {
			isPaused = false; //Changes the value
		}
		else{
			isPaused = true;
		}
	}
}
