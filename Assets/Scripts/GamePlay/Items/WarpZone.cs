using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpZone : MonoBehaviour {
	// 10秒間有効
	void Start () {
		Invoke("delete", 10f);
	}
	void delete() {
		Destroy(gameObject);
	}
	// ボールを上に移動させる
	void OnCollisionEnter(Collision col) {
		if ( col.gameObject.tag == "Ball" ) {
  			col.gameObject.transform.position = new Vector3(col.gameObject.transform.position.x, 44f, col.gameObject.transform.position.z);
		}
	}
}
