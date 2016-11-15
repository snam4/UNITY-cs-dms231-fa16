using UnityEngine;
using System.Collections;

public class lookAtDamping : MonoBehaviour {
	public Transform target;
	Transform enemy;
	public float damp = 10.0f;
	// Use this for initialization
	void Start () {
		enemy = transform;
	}
	
	// Update is called once per frame
	void OnTriggerStay (Collider player) {
		Quaternion rotate = Quaternion.LookRotation (target.position - enemy.position);
		enemy.rotation = Quaternion.Slerp (enemy.rotation, rotate, Time.deltaTime * damp); 
	}	
}
