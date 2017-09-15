using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage01 {
	// 正面から見たyx平面
	public int[,] yx0 = {
		{0,0,0,0,0,0,0},
		{0,0,0,0,0,0,0},
		{0,0,0,0,0,0,0},
		{0,0,0,0,0,0,0},
		{0,0,0,0,0,0,0}
	};
	public int[,] yx1 = {
		{0,0,0,0,0,0,0},
		{0,0,0,0,0,0,0},
		{0,0,0,0,0,0,0},
		{0,1,1,1,1,1,0},
		{1,1,1,1,1,1,1}
	};
	public int[,] yx2 = {
		{0,0,0,0,0,0,0},
		{0,0,0,0,0,0,0},
		{0,0,1,1,1,0,0},
		{0,1,1,1,1,1,0},
		{1,1,1,1,1,1,1}
	};
	public int[,] yx3 = {
		{0,0,0,0,0,0,0},
		{0,0,0,1,0,0,0},
		{0,0,1,1,1,0,0},
		{0,1,1,1,1,1,0},
		{1,1,1,1,1,1,1}
	};
	public int[,] yx4 = {
		{0,0,0,0,0,0,0},
		{0,0,0,0,0,0,0},
		{0,0,1,1,1,0,0},
		{0,1,1,1,1,1,0},
		{1,1,1,1,1,1,1}
	};
	public int[,] yx5 = {
		{0,0,0,0,0,0,0},
		{0,0,0,0,0,0,0},
		{0,0,1,1,1,0,0},
		{0,1,1,1,1,1,0},
		{1,1,1,1,1,1,1}
	};
	public int[,] yx6 = {
		{0,0,0,0,0,0,0},
		{0,0,0,0,0,0,0},
		{0,0,0,0,0,0,0},
		{0,0,0,0,0,0,0},
		{0,0,0,0,0,0,0}
	};
	public int ct = 0;
	public Stage01() {
		ct += blockCount(yx0);
		ct += blockCount(yx1);
		ct += blockCount(yx2);
		ct += blockCount(yx3);
		ct += blockCount(yx4);
		ct += blockCount(yx5);
		ct += blockCount(yx6);
		GameManager.blockCt = ct;
	}
	int blockCount(int[,] yx) {
		int ct = 0;
		for ( int y = 0; y < 5; y++ ) {
			for ( int x = 0; x < 7; x++ ) {
				if ( yx[y,x] != 0 ) {
					ct++;
				}
			}
		}
		return ct;
	}
}
