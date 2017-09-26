using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StageClick : MonoBehaviour {
	public void numClick(int num) {
		StageSelect.stageNum = num;
		StartCoroutine(GoToNextScene(2));
	}

	IEnumerator GoToNextScene(int index) {
		Instantiate(GetComponent<StageSelect>().fadeOut);
		yield return new WaitForSeconds (1f);
		SceneManager.LoadScene (index);
	}
	
}
