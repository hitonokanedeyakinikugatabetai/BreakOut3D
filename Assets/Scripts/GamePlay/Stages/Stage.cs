using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage : MonoBehaviour {
	// ブロックの数を返却
	protected int blockCount(int[,] yx) {
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
