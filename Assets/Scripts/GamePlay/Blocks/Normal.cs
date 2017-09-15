using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Normal : Block {
	void Start() {
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
	public Normal() {
		hp = 1;
	}
}
