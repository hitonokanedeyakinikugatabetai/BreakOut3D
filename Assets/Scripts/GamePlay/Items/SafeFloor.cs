using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeFloor : MonoBehaviour {
	// 衝突判定
	void OnCollisionEnter(Collision col) {
		if ( col.gameObject.tag == "Ball" ) {
  			Destroy(gameObject);
		}
	}
}
