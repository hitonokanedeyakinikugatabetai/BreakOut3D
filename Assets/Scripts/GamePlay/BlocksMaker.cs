using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlocksMaker : MonoBehaviour {
	//横x7 縦y5 奥z7
	int lenX = 7;
	int lenY = 5;
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
	private GameObject safeFloorBlock;
	private GameObject ballAdderBlock;
	private GameObject warpBlock;
	private Stage01 stage01 = new Stage01(); // ブロックの配置
	public BlocksMaker(int stageNum) {
		// ブロックを貰ってくる
		blocksHolder = GameObject.Find("GameManager").GetComponent<BlocksHolder>();
		normal = blocksHolder.blocks[0];
		safeFloorBlock = blocksHolder.blocks[1];
		ballAdderBlock = blocksHolder.blocks[2];
		warpBlock = blocksHolder.blocks[3];
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
		for ( int y = 0; y < lenY; y++ ) {
			for ( int x = 0; x < lenX; x++ ) {
				float posx = -11f + x * 3.5f;
				float posy = 43.5f - y * 1.5f;
				float posz = -12.5f + z * 3.5f;
				switch( yx[y,x] ) {
					case 0 :
						break;
					case 1 :
						Instantiate(normal, new Vector3(posx , posy, posz), Quaternion.identity);
						break;
					case 2 :
						Instantiate(safeFloorBlock, new Vector3(posx , posy, posz), Quaternion.identity);
						break;
					case 3 :
						Instantiate(ballAdderBlock, new Vector3(posx , posy, posz), Quaternion.identity);
						break;
					case 4 :
						Instantiate(warpBlock, new Vector3(posx , posy, posz), Quaternion.identity);
						break;
				}
			}
		}
	}
}