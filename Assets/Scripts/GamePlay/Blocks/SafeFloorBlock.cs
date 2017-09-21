using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SafeFloorBlock : Block {
	public GameObject safeFloor;
	public SafeFloorBlock()  {
		hp = 1;
	}
	void OnCollisionEnter(Collision col) {
		if ( col.gameObject.tag == "Ball" ) {
			makeSafeFloor();
			GameManager.blockCt--;
			GameObject.Find("BlockCount").GetComponent<Text>().text = "REST " + GameManager.blockCt.ToString();
  			Destroy(gameObject);
		}
	}
	void makeSafeFloor() {
		for ( int z = 0; z < 3; z++ ) {
			for ( int x = 0; x < 3; x++ ) {
				Instantiate(safeFloor, new Vector3(-10f + x * 10f, -2.5f, -10f + z * 10f) , Quaternion.identity);
			}
		}
	}
}
