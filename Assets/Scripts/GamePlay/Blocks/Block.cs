using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 全ブロックの親クラス
public class Block : MonoBehaviour {
	protected int hp;
	//衝突判定
	void OnCollisionEnter(Collision col){
		if ( hp == 1 ) {
			GameManager.blockCt--;
			GameObject.Find("BlockCount").GetComponent<Text>().text = "REST " + GameManager.blockCt.ToString();
  			Destroy(gameObject);
		} else {
			hp--;
		}
	}
}
