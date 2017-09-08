using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	public GameObject remain; // 残機表示オブジェクト
	public GameObject gameover; //ゲームオーバー表示オブジェクト
	public static int rem; // 残機数
	public static bool ballAlive; // ボールが消えているかどうか
	public GameObject player; // プレイヤー
	public GameObject ball; // ボール
	void Start () {
		rem = 3; // 残機初期化
		remain.GetComponent<Text>().text = "ooo"; // 残機表示初期化
		gameover.GetComponent<Text>().enabled = false; // ゲームオーバーを非表示に初期化
		// プレイヤーとボールを生成
		Instantiate(player);
		Instantiate(ball);
		ballAlive = true;
		// ブロック生成

	}
	void Update () {
		// ボールが消えているならBでボール生成
		if ( ballAlive == false && Input.GetKeyDown(KeyCode.B) && rem > -1) {
			Instantiate(ball);
			ballAlive = true;
		}
		//ゲームオーバー
		if ( rem == -1 ) {
			gameover.GetComponent<Text>().enabled = true; // 表示
		}
		// テスト用 escapeでシーン再読込み
		if ( Input.GetKeyDown(KeyCode.Escape) ) {
			SceneManager.LoadScene("GamePlay");
		}
	}
}