using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour {
	float posx;
	float posy;
	float posz;
	GameObject ball;
	void Start () {
		ball = GameObject.Find("Ball");
	}
	
	// Update is called once per frame
	void Update () {
		posx = ball.transform.position.x;
		posy = ball.transform.position.y;
		posz = ball.transform.position.z;
		transform.position = new Vector3(posx, posy - 30, posz);
	}
}