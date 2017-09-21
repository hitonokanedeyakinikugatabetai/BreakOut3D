using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour {
	public float speed;
	private float red, green, blue;
	private float alfa;
	void Start() {
		alfa = 0f;
		red = GetComponent<Image>().color.r;
		green = GetComponent<Image>().color.g;
		blue = GetComponent<Image>().color.b;
	}
	void Update() {
		GetComponent<Image>().color = new Color(red, green, blue, alfa);
		alfa += speed;
	}
}
