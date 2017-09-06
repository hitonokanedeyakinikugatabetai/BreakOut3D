using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineY : MonoBehaviour {
	float posx;
	float posz;
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
			posz = obj.transform.position.z;
			transform.position = new Vector3(posx, 0f, posz);
		}
	}
}