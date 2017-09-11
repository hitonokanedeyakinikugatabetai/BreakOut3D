using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlocksMaker : MonoBehaviour {
	//横x7 縦y5 奥z7
	private int stageNum;
	private int[,] yx0;
	private int[,] yx1;
	private int[,] yx2;
	private int[,] yx3;
	private int[,] yx4;
	private int[,] yx5;
	private int[,] yx6;
	private BlocksHolder blocksHolder; // ブロックまとめ
	private GameObject normal; // ブロックのプレハブ
	private Stage01 stage01 = new Stage01(); // ブロックの配置
	public BlocksMaker(int stageNum) {
		// ブロックを貰ってくる
		blocksHolder = GameObject.Find("GameManager").GetComponent<BlocksHolder>();
		normal = blocksHolder.normal;
		// 選んだステージのブロック配置をコピー
		switch( stageNum ) {
			case 1 :
				yx0 = stage01.yx0;
				yx1 = stage01.yx1;
				yx2 = stage01.yx2;
				yx3 = stage01.yx3;
				yx4 = stage01.yx4;
				yx5 = stage01.yx5;
				yx6 = stage01.yx6;
				break;
		}
	}
	// ブロック生成用関数
	// 0空白,1ノーマル,2~特殊
	public void makeBlocks() {
		int z = 0;
		makeSquare(yx0, z++);
		makeSquare(yx1, z++);
		makeSquare(yx2, z++);
		makeSquare(yx3, z++);
		makeSquare(yx4, z++);
		makeSquare(yx5, z++);
		makeSquare(yx6, z);

	}
	void makeSquare(int[,] yx, int z) {
		for ( int y = 0; y < 5; y++ ) {
			for ( int x = 0; x < 7; x++ ) {
				switch( yx[y,x] ) {
					case 0 :
						break;
					case 1 :
						Instantiate(normal, new Vector3(-11f + x * 3.5f , 43.5f - y * 1.5f, -12.5f + z * 3.5f ), Quaternion.identity);
						break;
				}
			}
		}
	}
}