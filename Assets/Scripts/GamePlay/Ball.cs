using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	public Vector3 first;
	void Start () {
		transform.GetComponent<Rigidbody>().velocity = first;
	}
	void OnTriggerEnter(Collider wall) {
		if ( wall.tag == "Bottom" ) {
			Destroy(gameObject);
		}
		if ( wall.tag == "Player" ) {
			this.GetComponent<Rigidbody>().AddForce(new Vector3(0f, 1000f ,0f));
		}
	}
	void OnCollisionEnter(Collision col){
		if ( col.gameObject.tag == "Ball" ) {
  			Destroy(gameObject);
		}
	}

}
