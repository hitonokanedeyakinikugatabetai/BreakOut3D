using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLineX : MonoBehaviour {
	float posy;
	float posz;
	public GameObject obj;
	public static bool alive;
	void Start () {
		alive = true;
	}
	//追従
	void Update () {
		if ( alive ) {
			posy = obj.transform.position.y;
			posz = obj.transform.position.z;
			transform.position = new Vector3(0f, posy, posz);
		}
	}
}
