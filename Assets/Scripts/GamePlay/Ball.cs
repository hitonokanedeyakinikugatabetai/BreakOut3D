using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour {
	public Vector3 first; // 初速度
	public GameObject linex, liney, linez; // ガイドラインプレハブ
	public float power; // プレイヤーの反射の力
	public static bool alive; // ボールが底に落ちていないかどうか
	void Start () {
		alive = true; // ボールの生存を初期化
		transform.GetComponent<Rigidbody>().velocity = first; // 初速度を追加
	}
	//衝突判定
	void OnCollisionEnter(Collision col) {
		// プレイヤーに当たったとき上向きの力を加える
		if ( col.gameObject.tag == "Player" && Input.GetKey(KeyCode.Space) ) {
			this.GetComponent<Rigidbody>().AddForce(new Vector3(0f, power, 0f));
		}
		if ( col.gameObject.tag == "Bottom" ) {
			//残機が0でないならリスタート
			GameManage.rem--;
			if ( GameManage.rem > -1 ) {
				transform.position = new Vector3(0f, 5f, 0f);
				GetComponent<Rigidbody>().velocity = first;
				// 残機の減少
				if ( GameManage.rem == 2 ) {
					GameObject.Find("Remain").GetComponent<Text>().text = "oo";
				} else if ( GameManage.rem == 1 ) {
					GameObject.Find("Remain").GetComponent<Text>().text = "o";
				} else if ( GameManage.rem == 0 ) {
					GameObject.Find("Remain").GetComponent<Text>().text = "";
				}
			} else {
				//残機が0なら削除
				LineX.alive = false;
				LineY.alive = false;
				LineZ.alive = false;
				Destroy(linex.gameObject);
				Destroy(liney.gameObject);
				Destroy(linez.gameObject);
				alive = false;
  				Destroy(gameObject);
			}
		}
	}
}
