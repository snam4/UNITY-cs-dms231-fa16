﻿using UnityEngine;
using System.Collections;

public class bulletProjectile : MonoBehaviour {
	float time = 0.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		transform.Translate (Vector3.forward * 20.0f * Time.deltaTime, Space.Self);
		if (time > 3.0f) {
			Destroy (gameObject);
		}
	}

	void OnCollisionEnter(Collision other){
		Destroy (gameObject);
	}
}
