using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyBall : MonoBehaviour {
	public Vector3 first; // 初速度
	private AudioSource[] audioSources; // 効果音
	private AudioSource normalSound;
	private AudioSource missSound;
	void Start () {
		audioSources = GetComponents<AudioSource>();
		normalSound = audioSources[0];
		missSound = audioSources[1];
		transform.GetComponent<Rigidbody>().velocity = first; // 初速度を追加
	}
	void Update() {
		// ブロックが0個、またはGAMEOVERなら
		if ( GameManager.blockCt == 0 || GameManager.rem < 0 ) {
			// 消去
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
			// 消去
			Destroy(gameObject);
		}
		// ノーマルブロックに当たったとき
		if ( col.gameObject.tag == "Normal" ) {
			// 効果音を再生
			AudioSource.PlayClipAtPoint(normalSound.clip, transform.position);
			AudioSource.PlayClipAtPoint(normalSound.clip, transform.position);
			AudioSource.PlayClipAtPoint(normalSound.clip, transform.position);
			AudioSource.PlayClipAtPoint(normalSound.clip, transform.position);
		}
	}
}
