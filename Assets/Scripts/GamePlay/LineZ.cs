using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineZ : MonoBehaviour {
	float posx;
	GameObject obj;
	void Start () {
		obj = GameObject.Find("Ball(Clone)");
	}
	//追従
	void Update () {
			posx = obj.transform.position.x;
			transform.position = new Vector3(posx, 0f, 0f);
	}
}