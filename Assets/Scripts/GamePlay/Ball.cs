using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour {
	public Vector3 first; // 初速度
	public GameObject lineX, lineY, lineZ; // ガイドラインプレハブ
	private GameObject player; // プレイヤー
	private AudioSource normalSound; // 効果音
	void Start () {
		normalSound = GetComponent<AudioSource>();
		player = GameObject.Find("Player(Clone)");
		transform.GetComponent<Rigidbody>().velocity = first; // 初速度を追加
		// プレイヤーの位置にガイドライン生成
		Instantiate(lineX, player.transform.position, lineX.transform.rotation);
		Instantiate(lineY, player.transform.position, lineY.transform.rotation);
		Instantiate(lineZ, player.transform.position, lineZ.transform.rotation);
		lineX = GameObject.Find("LineX(Clone)");
		lineY = GameObject.Find("LineY(Clone)");
		lineZ = GameObject.Find("LineZ(Clone)");
	}
	void Update() {
		// ブロックが0個なら
		if ( GameManager.blockCt == 0 ) {
			// 消去
			Destroy(lineX.gameObject);
			Destroy(lineY.gameObject);
			Destroy(lineZ.gameObject);
			Destroy(gameObject);
		}
	}
	//衝突判定
	void OnCollisionEnter(Collision col) {
		// 床に当たったとき残機を減らして消去
		if ( col.gameObject.tag == "Bottom" ) {
			GameManager.rem--;
			GameManager.ballAlive = false;
			// 消去
			Destroy(lineX.gameObject);
			Destroy(lineY.gameObject);
			Destroy(lineZ.gameObject);
			Destroy(gameObject);
		}
		// ノーマルブロックに当たったとき
		if ( col.gameObject.tag == "Normal" ) {
			AudioSource.PlayClipAtPoint(normalSound.clip, transform.position);
			AudioSource.PlayClipAtPoint(normalSound.clip, transform.position);
			AudioSource.PlayClipAtPoint(normalSound.clip, transform.position);
			AudioSource.PlayClipAtPoint(normalSound.clip, transform.position);
			AudioSource.PlayClipAtPoint(normalSound.clip, transform.position);
		}
	}
}