using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineY : MonoBehaviour {
	float posx;
	float posz;
	GameObject obj;
	void Start () {
		obj = GameObject.Find("Ball(Clone)");
	}
	//追従
	void Update () {
			posx = obj.transform.position.x;
			posz = obj.transform.position.z;
			transform.position = new Vector3(posx, 15f, posz);
	}
}