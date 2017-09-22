using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StageClick : MonoBehaviour {
	public void numClick() {
		StageSelect.stageNum = Int32.Parse(transform.Find("Text").gameObject.GetComponent<Text>().text);
		StartCoroutine(GoToNextScene(0));
	}

	IEnumerator GoToNextScene(int index) {
		Instantiate(GetComponent<StageSelect>().fadeOut);
		yield return new WaitForSeconds (1f);
		SceneManager.LoadScene (index);
	}
	
}
