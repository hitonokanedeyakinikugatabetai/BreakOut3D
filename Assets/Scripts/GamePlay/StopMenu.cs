using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StopMenu : MonoBehaviour {
	public GameObject fadeOut;
	private Canvas menu;
	void Start() {
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
		Instantiate(fadeOut);
		StartCoroutine(GoToNextScene(1));
	}
	public void retry() {
		Time.timeScale = 1;
		Instantiate(fadeOut);
		StartCoroutine(GoToNextScene(2));
	}
	public void resume() {
		menu.enabled = false;
		Cursor.visible = false;
		Time.timeScale = 1;
	}
	IEnumerator GoToNextScene(int index) {
		yield return new WaitForSeconds (1f);
		SceneManager.LoadScene (index);
	}
}