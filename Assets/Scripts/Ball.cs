using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	public Vector3 first;
	void Start () {
		transform.GetComponent<Rigidbody>().velocity = first;
	}
	void OnTriggerEnter(Collider wall) {
		if ( wall.tag=="Bottom" ) {
			Destroy(gameObject);
		}
	}
}
