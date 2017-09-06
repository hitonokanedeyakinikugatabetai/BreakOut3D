using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour {
	float posx;
	float posy;
	float posz;
	GameObject ball;
	public static bool alive;
	void Start () {
		alive = true;
		ball = GameObject.Find("Ball");
	}
	
	// Update is called once per frame
	void Update () {
		if ( alive ) {
			posx = ball.transform.position.x;
			posy = ball.transform.position.y;
			posz = ball.transform.position.z;
			transform.position = new Vector3(posx, posy - 40, posz);
		}
	}
}