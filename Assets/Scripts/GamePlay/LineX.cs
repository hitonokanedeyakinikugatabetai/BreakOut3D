using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineX : MonoBehaviour {
	float posz; // ボールのz座標
	GameObject obj; // ボール
	public static bool alive; // ボールが落ちたとき一緒に消すためのフラグ
	void Start () {
		// 初期化
		alive = true;
		obj = GameObject.Find("Ball");
	}
	//追従
	void Update () {
		// ボールに追従
		if ( alive ) {
			posz = obj.transform.position.z;
			transform.position = new Vector3(0f, 0f, posz);
		}
	}
}