using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalSound : MonoBehaviour {
	private AudioSource audioSource;    // Audiosorceを格納する変数の宣言
	public  AudioClip   sound;          // 効果音を格納する変数の宣言

	// Use this for initialization
	void Start () {
		audioSource = gameObject.AddComponent<AudioSource>();	// AudioSourceコンポーネントを追加し、変数に代入
		audioSource.clip = sound;	// 鳴らす音(変数)を格納
		audioSource.loop = false;	// 音のループなし
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision) {
		// Ballに当たると音が鳴る
		if (collision.gameObject.tag == "Ball") {
			audioSource.Play(); 
		}
	}
}
