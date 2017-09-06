using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineZ : MonoBehaviour {
	float posx;
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
			transform.position = new Vector3(posx, 0f, 0f);
		}
	}
}
