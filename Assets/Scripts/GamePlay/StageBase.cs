using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageBase : MonoBehaviour {
	//横x7 縦y5 奥z7
	public int[,,] blocks = new int[5, 7, 7];
	public GameObject normal; // ブロックのプレハブ
	void Start () {
		CreateBlocks(blocks); // ブロックの生成
	}
	// ブロック生成用関数
	// 0空白,1ノーマル,2~特殊
	void CreateBlocks(int[,,] blocks) {
		for ( int x = 0; x < 7; x++ ) {
			for ( int y = 0; y < 5; y++ ) {
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
}
