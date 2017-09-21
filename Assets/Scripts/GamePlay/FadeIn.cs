using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour {
	public float speed;
	private float red, green, blue;
	private float alfa;
	void Start() {
		alfa = 1f;
		red = GetComponent<Image>().color.r;
		green = GetComponent<Image>().color.g;
		blue = GetComponent<Image>().color.b;
		StartCoroutine(destroyGameobject());
	}
	void Update() {
		GetComponent<Image>().color = new Color(red, green, blue, alfa);
		alfa -= speed;
	}
	IEnumerator destroyGameobject(){
		yield return new WaitForSeconds (1f);
		Destroy(gameObject);
	}
}
