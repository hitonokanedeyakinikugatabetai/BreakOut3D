using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineX : MonoBehaviour {
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
			posz = obj.transform.position.z;
			transform.position = new Vector3(0f, 0f, posz);
		}
	}
}
