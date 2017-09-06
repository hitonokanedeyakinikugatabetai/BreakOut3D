using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour {
	public Vector3 first;
	public GameObject linex, liney, linez;
	public float power;
	public static bool alive; 
	void Start () {
		alive = true;
		transform.GetComponent<Rigidbody>().velocity = first;
	}
	//衝突判定
	void OnCollisionEnter(Collision col) {
		//上向きの力
		if ( col.gameObject.tag == "Player" && Input.GetKey(KeyCode.Space) ) {
			this.GetComponent<Rigidbody>().AddForce(new Vector3(0f, power, 0f));
		}
		if ( col.gameObject.tag == "Bottom" ) {
			//残機が0でないならリスタート
			GameManage.rem--;
			if ( GameManage.rem > -1 ) {
				transform.position = new Vector3(0f, 5f, 0f);
				GetComponent<Rigidbody>().velocity = first;
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
