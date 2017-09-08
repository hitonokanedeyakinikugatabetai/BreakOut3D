using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineX : MonoBehaviour {
	float posz; // ボールのz座標
	GameObject obj; // ボール
	void Start () {
		// 初期化
		obj = GameObject.Find("Ball(Clone)");
	}
	//追従
	void Update () {
		// ボールに追従
			posz = obj.transform.position.z;
			transform.position = new Vector3(0f, 0f, posz);
	}
}