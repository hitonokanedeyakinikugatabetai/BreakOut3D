using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectStage1 : MonoBehaviour {

	public GameObject SelectCam;
	public string SelectScene;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)){
			SceneManager.LoadScene("StageSelect");
		}
	}
}
