using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	float size;
	public float power;
	public float mouse_x_delta;
	public float mouse_y_delta;
	public float sensitivity = 0.1f;
	public float speed;
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
		if (Input.GetKeyDown(KeyCode.Space)) {
			GetComponent<Renderer>().material.color = new Color(50f / 255f, 50f / 255f, 255f / 255f);
		}
		if (Input.GetKeyUp(KeyCode.Space)) {
			GetComponent<Renderer>().material.color = new Color(120f / 255f, 120f / 255f, 255f / 255f);
		}
	}
	void OnCollisionEnter(Collision col) {
		if ( col.gameObject.tag == "Ball" && Input.GetKey(KeyCode.Space) ) {
			if ( mouse_x_delta > 0 ) {
				col.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(speed, 0f, 0f));
			}
			if ( mouse_x_delta < 0 ) {
				col.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(speed, 0f, 0f));
			}
			if ( mouse_y_delta > 0 ) {
				col.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0f, 0f, speed));
			}
			if ( mouse_y_delta < 0 ) {
				col.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0f, 0f, speed));
			}
			//上向きの力
			col.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0f, power, 0f));
		}
	}
}
