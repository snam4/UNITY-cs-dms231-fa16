using UnityEngine;
using System.Collections;

public class enemyLookAt : MonoBehaviour {
	public Transform target;
	Transform me;
	public float damp = 10.0f;

	// Use this for initialization
	void Start () {
		me = transform;
	}
	
	// Update is called once per frame
	void Update () {
		Quaternion rotate = Quaternion.LookRotation(target.position - me.position);
		me.rotation = Quaternion.Slerp (me.rotation, rotate, Time.deltaTime * damp);
	}
}
