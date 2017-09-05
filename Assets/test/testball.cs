using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testball : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.GetComponent< Rigidbody >().velocity = new Vector3(5.0f , 5.0f , 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
