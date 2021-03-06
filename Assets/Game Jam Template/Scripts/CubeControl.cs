﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour {

	Rigidbody rigidBody;
	public Vector3 force = new Vector3(0, 10, 0);
	public ForceMode forceMode = ForceMode.VelocityChange;
	// Use this for initialization
	void Start () {
		rigidBody = gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	public void OnUserAction () {
		rigidBody.AddForce(force, forceMode);
	}
}
