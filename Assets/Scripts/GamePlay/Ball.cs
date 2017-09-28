using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour {
	public Vector3 first; // 初速度
	public GameObject lineX, lineY, lineZ; // ガイドラインプレハブ
	private GameObject player; // プレイヤー
	private AudioSource[] audioSources; // 以下 効果音
	private AudioSource normalSound;
	private AudioSource missSound;
	private AudioSource itemSound;
	void Start () {
		audioSources = GetComponents<AudioSource>(); // 効果音を追加
		normalSound = audioSources[0];
		missSound = audioSources[1];
		itemSound = audioSources[2];
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
		// 床に当たったとき
		if ( col.gameObject.tag == "Bottom" ) {
			// 効果音を再生
			AudioSource.PlayClipAtPoint(missSound.clip, transform.position);
			AudioSource.PlayClipAtPoint(missSound.clip, transform.position);
			AudioSource.PlayClipAtPoint(missSound.clip, transform.position);
			AudioSource.PlayClipAtPoint(missSound.clip, transform.position);
			AudioSource.PlayClipAtPoint(missSound.clip, transform.position);
			// 残機を減らす
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
			// 効果音を再生
			AudioSource.PlayClipAtPoint(normalSound.clip, transform.position);
			AudioSource.PlayClipAtPoint(normalSound.clip, transform.position);
			AudioSource.PlayClipAtPoint(normalSound.clip, transform.position);
			AudioSource.PlayClipAtPoint(normalSound.clip, transform.position);
			AudioSource.PlayClipAtPoint(normalSound.clip, transform.position);
		}
		// アイテムブロックに当たったとき
		if ( col.gameObject.tag == "Item" ) {
			// 効果音を再生
			AudioSource.PlayClipAtPoint(itemSound.clip, transform.position);
			AudioSource.PlayClipAtPoint(itemSound.clip, transform.position);
			AudioSource.PlayClipAtPoint(itemSound.clip, transform.position);
		}
	}
}