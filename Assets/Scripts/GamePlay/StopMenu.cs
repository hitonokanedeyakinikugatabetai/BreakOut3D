using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StopMenu : MonoBehaviour {
	Canvas menu;
	int sceneIndex;
	void Start() {
		sceneIndex = SceneManager.GetActiveScene().buildIndex;
		menu = GetComponent<Canvas>();
		menu.enabled = false;
	}
	void Update () {
		if ( Input.GetKeyDown(KeyCode.Escape) ) {
			if ( menu.enabled ) {
				menu.enabled = false;
				Cursor.visible = false;
				Time.timeScale = 1;
			} else {
				menu.enabled = true;
				Cursor.visible = true;
				Time.timeScale = 0;
			}
		}
	}
	public void stageSelect() {
		Time.timeScale = 1;
		SceneManager.LoadScene("Menu");
	}
	public void retry() {
		Time.timeScale = 1;
		SceneManager.LoadScene(sceneIndex);
	}
	public void resume() {
		menu.enabled = false;
		Cursor.visible = false;
		Time.timeScale = 1;
	}
}