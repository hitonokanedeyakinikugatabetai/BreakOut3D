using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WarpBlock : Block {
	public GameObject warpZone;
	public WarpBlock() {
		hp = 1;
	}
	void OnCollisionEnter(Collision col){
		if ( col.gameObject.tag == "Ball" ) {
			GameManager.blockCt--;
			GameObject.Find("BlockCount").GetComponent<Text>().text = "残り " + GameManager.blockCt.ToString();
			Instantiate(warpZone);
  			Destroy(gameObject);
		}
	}
}
