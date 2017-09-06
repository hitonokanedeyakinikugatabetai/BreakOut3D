using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour {
	public GameObject remain;
	public GameObject gameover;
	public static int rem;
	public GameObject ball;
	public GameObject linex;
	public GameObject liney;
	public GameObject linez;
	void Start () {
		rem = 3;
		remain.GetComponent<Text>().text = "ooo";
		gameover.GetComponent<Text>().enabled = false;
		// Instantiate(ball);
		// Instantiate(linex);
		// Instantiate(liney);
		// Instantiate(linez);
	}
	void Update () {
		//ゲームオーバー
		if ( rem == -1 ) {
			gameover.GetComponent<Text>().enabled = true;
		}
		if ( Input.GetKeyDown(KeyCode.Escape) ) {
			SceneManager.LoadScene("GamePlay");
		}
	}
}