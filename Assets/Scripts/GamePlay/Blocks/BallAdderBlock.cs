using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallAdderBlock : Block {
	public GameObject dummyBall;
	public BallAdderBlock() {
		hp = 1;
	}
	void OnCollisionEnter(Collision col) {
		if ( col.gameObject.tag == "Ball" ) {
			ballAdd();
			GameManager.blockCt--;
			GameObject.Find("BlockCount").GetComponent<Text>().text = "REST " + GameManager.blockCt.ToString();
  			Destroy(gameObject);
		}
	}
	void ballAdd() {
		Instantiate(dummyBall, transform.position, Quaternion.identity);
	}
}
