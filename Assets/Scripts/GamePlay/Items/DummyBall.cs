using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyBall : MonoBehaviour {
public Vector3 first; // 初速度
	private AudioSource normalSound; // 効果音
	void Start () {
		normalSound = GetComponent<AudioSource>();
		transform.GetComponent<Rigidbody>().velocity = first; // 初速度を追加
	}
	void Update() {
		// ブロックが0個なら
		if ( GameManager.blockCt == 0 ) {
			// 消去
			Destroy(gameObject);
		}
	}
	//衝突判定
	void OnCollisionEnter(Collision col) {
		// 床に当たったとき残機を減らして消去
		if ( col.gameObject.tag == "Bottom" ) {
			// 消去
			Destroy(gameObject);
		}
		// ノーマルブロックに当たったとき
		if ( col.gameObject.tag == "Normal" ) {
			AudioSource.PlayClipAtPoint(normalSound.clip, transform.position);
			AudioSource.PlayClipAtPoint(normalSound.clip, transform.position);
			AudioSource.PlayClipAtPoint(normalSound.clip, transform.position);
			AudioSource.PlayClipAtPoint(normalSound.clip, transform.position);
		}
	}
}
