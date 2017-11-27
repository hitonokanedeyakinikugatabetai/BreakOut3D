using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeFloor : MonoBehaviour {
	private AudioSource[] audioSources; // 以下 効果音
	private AudioSource sfActivate; // 発動音
	private AudioSource sfSound; // 衝突音

	void Start() {
		// 効果音追加
		audioSources = GetComponents<AudioSource>();
		sfActivate = audioSources[0];
		sfSound = audioSources[1];
		AudioSource.PlayClipAtPoint(sfActivate.clip, transform.position);
	}
	// 衝突判定
	void OnCollisionEnter(Collision col) {
		if ( col.gameObject.tag == "Ball" ) {
			AudioSource.PlayClipAtPoint(sfSound.clip, transform.position);
  			Destroy(gameObject);
		}
	}
}
