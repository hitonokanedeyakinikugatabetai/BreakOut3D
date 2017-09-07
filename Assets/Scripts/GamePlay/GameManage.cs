using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour {
	public GameObject remain; // 残機表示オブジェクト
	public GameObject gameover; //ゲームオーバー表示オブジェクト
	public static int rem; // 残機数
	public GameObject ball; // ボール
	// public GameObject linex; // ガイドライン
	// public GameObject liney;
	// public GameObject linez;
	void Start () {
		rem = 3; // 残機初期化
		remain.GetComponent<Text>().text = "ooo"; // 残機表示初期化
		gameover.GetComponent<Text>().enabled = false; // ゲームオーバーを非表示に初期化
		// Instantiate(ball);
		// Instantiate(linex);
		// Instantiate(liney);
		// Instantiate(linez);
	}
	void Update () {
		//ゲームオーバー
		if ( rem == -1 ) {
			gameover.GetComponent<Text>().enabled = true; // 表示
		}
		if ( Input.GetKeyDown(KeyCode.Escape) ) {
			SceneManager.LoadScene("GamePlay"); // シーン再読込み
		}
	}
}