using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	private float size; // プレイヤーのサイズ
	public float power; // 反射の力
	private float mouse_x_delta; // マウス座標の変化量
	private float mouse_y_delta;
	public float sensitivity = 0.1f; // 倍率
	public float speed; // 移動に応じて追加する速度の倍率
	private Material material;
	void Start() {
		material = GetComponent<Renderer>().material;
		// マウスカーソルを映さない
		Cursor.visible = false;
		// プレイヤーのサイズ
		size = transform.localScale.x;
	}
	//マウス移動
	void Update () {
		mouse_x_delta = Input.GetAxis("Mouse X") * sensitivity; // マウスの座標
		mouse_y_delta = Input.GetAxis("Mouse Y") * sensitivity;
		// ステージ内かどうか
		if ( mouse_x_delta > 0 && transform.position.x <= 14f - size / 2f ) {
			transform.position += new Vector3(mouse_x_delta, 0f, 0f);
		}
		if ( mouse_x_delta < 0 && transform.position.x >= -14f + size / 2f ) {
			transform.position += new Vector3(mouse_x_delta, 0f, 0f);
		}
		if ( mouse_y_delta > 0 && transform.position.z <= 14f - size / 2f ) {
			transform.position += new Vector3(0f, 0f, mouse_y_delta);
		}
		if ( mouse_y_delta < 0 && transform.position.z >= -14f + size / 2f ) {
			transform.position += new Vector3(0f, 0f, mouse_y_delta);
		}
		// スペースキーを押したら色変更
		if ( Input.GetKeyDown(KeyCode.Space) ) {
			material.color = new Color(120f / 255f, 120f / 255f, 255f / 255f);
		}
		// スペースキーを離したら色変更
		if ( Input.GetKeyUp(KeyCode.Space) ) {
			material.color = new Color(50f / 255f, 50f / 255f, 255f / 255f);
		}
		// debug用オートパイロット
		GameObject ball = GameObject.Find("Ball(Clone)");
		transform.position = new Vector3(ball.transform.position.x, 0f, ball.transform.position.z);
	}
	// 衝突判定
	void OnCollisionEnter(Collision col) {
		// ボールに当たったとき
		if ( col.gameObject.tag == "Ball" ) {
			if ( Input.GetKey(KeyCode.Space) ) {
				//上向きの力と前後左右の力
				col.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(speed * mouse_x_delta, power, speed * mouse_y_delta));
			} else {
				// 前後左右の力のみ
				col.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(speed * mouse_x_delta, 0f, speed * mouse_y_delta));
			}
		}
	}
}
