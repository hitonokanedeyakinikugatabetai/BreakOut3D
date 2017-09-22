using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hard : Block {

	public Hard() {
		hp = 3;
	}
	public Material[] _material;

	void Update() {
		// hpの値によって色が変化
		if ( hp == 2 ) {
			// 色の変更
			this.GetComponent<Renderer>().material = _material[1];
		} else if ( hp == 1 ) {
			// 色の変更
			if ( transform.position.y > 43 ) {
				GetComponent<Renderer>().material.color = new Color(255f / 255f, 0f / 255f, 0f / 255f);
			} else if ( transform.position.y > 41.5 ) {
				GetComponent<Renderer>().material.color = new Color(255f / 255f, 255f / 255f, 0f / 255f);
			} else if ( transform.position.y > 40 ) {
				GetComponent<Renderer>().material.color = new Color(0f / 255f, 255f / 255f, 0f / 255f);
			} else if ( transform.position.y > 38.5 ) {
				GetComponent<Renderer>().material.color = new Color(0f / 255f, 0f / 255f, 255f / 255f);
			} else {
				GetComponent<Renderer>().material.color = new Color(255f / 255f, 0f / 255f, 255f / 255f);
			}
		}
	}
}
