using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpZone : MonoBehaviour {
	private AudioSource[] audioSources; // 以下 効果音
	private AudioSource warpActivate; // 発動音
	private AudioSource warpSound; // ワープ音
	void Start () {
		// 効果音を追加
		audioSources = GetComponents<AudioSource>();
		warpActivate = audioSources[0];
		warpSound = audioSources[1];
		AudioSource.PlayClipAtPoint(warpActivate.clip, transform.position);
		// 10秒間有効
		Invoke("delete", 10f);
	}
	void delete() {
		Destroy(gameObject);
	}
	void OnCollisionEnter(Collision col) {
		if ( col.gameObject.tag == "Ball" ) {
			// ボールを上に移動させる
  			col.gameObject.transform.position = new Vector3(col.gameObject.transform.position.x, 44f, col.gameObject.transform.position.z);
			AudioSource.PlayClipAtPoint(warpSound.clip, transform.position);
		}
	}
}
