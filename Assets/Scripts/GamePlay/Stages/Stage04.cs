using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage04 : Stage {
	// 正面から見たyx平面
	public int[,] yx0 = {
		{0,0,0,0,0,0,0},
		{0,0,0,0,0,0,0},
		{1,0,0,0,0,0,1},
		{1,1,1,1,1,1,1},
		{3,3,3,3,3,3,3}
	};
	public int[,] yx1 = {
		{0,0,0,0,0,0,0},
		{1,0,0,0,0,0,1},
		{1,0,0,0,0,0,1},
		{1,1,1,1,1,1,1},
		{3,3,3,3,3,3,3}
	};
	public int[,] yx2 = {
		{0,0,4,4,4,0,0},
		{1,0,0,0,0,0,1},
		{0,0,1,1,1,0,0},
		{1,1,1,1,1,1,1},
		{1,1,1,1,1,1,1}
	};
	public int[,] yx3 = {
		{0,0,0,3,0,0,0},
		{1,0,0,3,0,0,1},
		{1,0,0,2,0,0,1},
		{1,1,1,1,1,1,1},
		{1,1,1,1,1,1,1}
	};
	public int[,] yx4 = {
		{0,0,4,4,4,0,0},
		{0,0,0,0,0,0,0},
		{1,0,0,0,0,0,1},
		{1,1,1,1,1,1,1},
		{1,1,1,1,1,1,1}
	};
	public int[,] yx5 = {
		{0,0,0,0,0,0,0},
		{0,0,0,0,0,0,0},
		{1,0,0,0,0,0,1},
		{1,1,1,1,1,1,1},
		{1,1,1,1,1,1,1}
	};
	public int[,] yx6 = {
		{0,0,0,0,0,0,0},
		{0,0,0,0,0,0,0},
		{1,0,0,0,0,0,1},
		{1,1,1,1,1,1,1},
		{1,1,1,1,1,1,1}
	};
	public int ct = 0;
	// ブロック数をカウント
	public Stage04() {
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
