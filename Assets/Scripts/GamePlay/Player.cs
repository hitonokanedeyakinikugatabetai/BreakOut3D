using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public float speed;
	float size;
	float mouse_x_delta;
	float mouse_y_delta;
	public float sensitivity = 0.1f;
	void Start() {
		Cursor.visible = false;
		size = transform.localScale.x;
	}
	//マウス移動
	void Update () {
		mouse_x_delta = Input.GetAxis("Mouse X") * sensitivity;
		mouse_y_delta = Input.GetAxis("Mouse Y") * sensitivity;
		if ( mouse_x_delta > 0 && transform.position.x <= 14f - size / 2f ) {
			transform.position += new Vector3(mouse_x_delta, 0f, 0f);
		}
		if ( mouse_x_delta < 0 && transform.position.x >= -14f + size / 2f ) {
			transform.position += new Vector3(mouse_x_delta, 0f, 0f);
		}
		if ( mouse_y_delta > 0 && transform.position.z <= 14f - size / 2f ) {
			transform.position += new Vector3(0f, 0f, mouse_y_delta);
		}
		if ( mouse_y_delta < 0 && transform.position.z >= -14f + size / 2f ) {
			transform.position += new Vector3(0f, 0f, mouse_y_delta);
		}
	}
}
