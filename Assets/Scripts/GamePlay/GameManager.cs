using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	public GameObject remain; // 残機表示オブジェクト
	public GameObject gameover; //ゲームオーバー表示オブジェクト
	public GameObject clear; //ゲームクリア表示オブジェクト
	public static int rem; // 残機数
	public static bool ballAlive; // ボールが消えているかどうか
	public GameObject player; // プレイヤー
	public GameObject ball; // ボール
	private BlocksMaker blocksMaker;
	private int stageNum;
	public static int blockCt;
	public GameObject fadeIn;
	void Start () {
		Instantiate(fadeIn);
		// マウスカーソルを映さない
		Cursor.visible = false;
		// ステージの番号を設定
		stageNum = StageSelect.stageNum;
		// ステージ番号のブロック配置の読み込み
		blocksMaker = new BlocksMaker(stageNum);
		rem = 3; // 残機初期化
		remain.GetComponent<Text>().text = "●●●"; // 残機表示初期化
		gameover.GetComponent<Text>().enabled = false; // ゲームオーバーを非表示に初期化
		clear.GetComponent<Text>().enabled = false; // ゲームクリアを非表示に初期化
		GameObject.Find("BlockCount").GetComponent<Text>().text = "REST " + GameManager.blockCt.ToString();
		// プレイヤーとボールを生成
		Instantiate(player);
		Instantiate(ball);
		ballAlive = true;
		// ブロック生成
		blocksMaker.makeBlocks();
	}
	void Update () {
		// ボールが消えているならBでボール生成
		if ( ballAlive == false && Input.GetKeyDown(KeyCode.B) && rem > -1) {
			Instantiate(ball);
			ballAlive = true;
			// 残機表示の更新
			if ( GameManager.rem == 2 ) {
				GameObject.Find("Remain").GetComponent<Text>().text = "●●";
			} else if ( GameManager.rem == 1 ) {
				GameObject.Find("Remain").GetComponent<Text>().text = "●";
			} else if ( GameManager.rem == 0 ) {
				GameObject.Find("Remain").GetComponent<Text>().text = "";
			}
		}
		if ( blockCt == 0 ) {
			clear.GetComponent<Text>().enabled = true; // 表示
		}
		//ゲームオーバー
		if ( rem == -1 ) {
			gameover.GetComponent<Text>().enabled = true; // 表示
		}
	}
}