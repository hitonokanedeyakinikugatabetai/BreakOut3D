using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLineZ : MonoBehaviour {
	float posx;
	float posy;
	public GameObject obj;
	public static bool alive;
	void Start () {
		alive = true;
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
