using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageBase : MonoBehaviour {
	//x7 y10 z7
	public int[, ,] blocks = new int[10, 7, 7];
	public GameObject normal;
	void Start () {
		for ( int x = 0; x < 7; x++ ) {
			for ( int y = 0; y < 10; y++ ) {
				for ( int z = 0; z < 7; z++ ) {
					switch(blocks[y,x,z]) {
						case 0 :
							Instantiate(normal, new Vector3(-11f + x * 3.5f , 43.5f - y * 1.5f, -12.5f + z * 3.5f ), Quaternion.identity);
							break;
						
					}
				}
			}
		}
	}
	void Update () {
		
	}
}
