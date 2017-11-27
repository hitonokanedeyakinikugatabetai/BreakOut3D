using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage02 : Stage {
	// 正面から見たyx平面
	public int[,] yx0 = {
		{1,5,1,5,1,5,1},
		{1,3,1,1,1,3,1},
		{2,1,3,5,3,1,2},
		{1,2,1,1,1,2,1},
		{1,5,3,1,3,5,1}
	};
	public int[,] yx1 = {
		{0,0,0,0,0,0,0},
		{0,5,1,1,1,1,0},
		{0,2,1,2,1,3,0},
		{0,1,5,1,1,1,0},
		{0,0,0,0,0,0,0}
	};
	public int[,] yx2 = {
		{0,0,0,0,0,0,0},
		{0,0,4,1,2,0,0},
		{0,0,1,1,3,0,0},
		{0,0,1,5,1,0,0},
		{0,0,0,0,0,0,0}
	};
	public int[,] yx3 = {
		{0,0,0,0,0,0,0},
		{0,0,0,0,0,0,0},
		{0,0,0,5,0,0,0},
		{0,0,0,0,0,0,0},
		{0,0,0,0,0,0,0}
	};
	public int[,] yx4 = {
		{0,0,0,0,0,0,0},
		{0,0,1,1,1,0,0},
		{0,0,1,4,3,0,0},
		{0,0,2,1,5,0,0},
		{0,0,0,0,0,0,0}
	};
	public int[,] yx5 = {
		{0,0,0,0,0,0,0},
		{0,5,1,1,1,5,0},
		{0,1,1,2,3,1,0},
		{0,2,3,1,2,4,0},
		{0,0,0,0,0,0,0}
	};
	public int[,] yx6 = {
		{5,1,1,1,1,1,5},
		{1,3,4,3,2,5,3},
		{3,1,1,5,1,1,1},
		{1,1,1,2,1,1,1},
		{1,1,2,1,1,1,1}
	};
	public int ct = 0;
	// ブロック数をカウント
	public Stage02() {
		ct += blockCount(yx0);
		ct += blockCount(yx1);
		ct += blockCount(yx2);
		ct += blockCount(yx3);
		ct += blockCount(yx4);
		ct += blockCount(yx5);
		ct += blockCount(yx6);
		GameManager.blockCt = ct;
	}
}
