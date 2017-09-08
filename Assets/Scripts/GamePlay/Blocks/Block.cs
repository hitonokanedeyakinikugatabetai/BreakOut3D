using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {
	protected int hp;
	//衝突判定
	void OnCollisionEnter(Collision col){
		if ( col.gameObject.tag == "Ball" && hp == 1 ) {
  			Destroy(gameObject);
		} else {
			hp--;
		}
	}
}
