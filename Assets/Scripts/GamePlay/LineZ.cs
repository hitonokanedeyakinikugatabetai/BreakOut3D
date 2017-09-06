using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineZ : MonoBehaviour {
	float posx;
	float posy;
	GameObject obj;
	public static bool alive;
	void Start () {
		alive = true;
		obj = GameObject.Find("Ball");
	}
	//追従
	void Update () {
		if ( alive ) {
			posx = obj.transform.position.x;
			posy = obj.transform.position.y;
			transform.position = new Vector3(posx, posy, 0f);
		}
	}
}
