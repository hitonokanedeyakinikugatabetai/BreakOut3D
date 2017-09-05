using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public float speed;
	public float size;
	void Start() {
		size = transform.localScale.x;
	}
	void Update () {
		if ( Input.GetKey(KeyCode.RightArrow) && transform.position.x <= 14f - size /2f ) {
			transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
		}
		if ( Input.GetKey(KeyCode.LeftArrow) && transform.position.x >= -14f + size / 2f ) {
			transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
		}
		if ( Input.GetKey(KeyCode.UpArrow) && transform.position.z <= 14f - size / 2f ) {
			transform.position += new Vector3(0, 0, speed * Time.deltaTime);
		}
		if ( Input.GetKey(KeyCode.DownArrow) && transform.position.z >= -14f + size / 2f ) {
			transform.position += new Vector3(0, 0, -speed * Time.deltaTime);
		}
	}
}
