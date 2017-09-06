using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	public Vector3 first;
	public GameObject line;
	void Start () {
		transform.GetComponent<Rigidbody>().velocity = first;
	}
	void OnCollisionEnter(Collision col){
		if ( col.gameObject.tag == "Bottom" ) {
			Line.alive = false;
			Destroy(line.gameObject);
  			Destroy(gameObject);
		}
		// if ( col.gameObject.tag == "Player" ) {
		// 	this.GetComponent<Rigidbody>().AddForce(new Vector3(0f, 1000f ,0f));
		// }
	}
}
