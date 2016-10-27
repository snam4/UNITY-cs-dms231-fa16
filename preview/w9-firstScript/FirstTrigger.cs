using UnityEngine;
using System.Collections;

public class FirstTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(){
		GetComponent<Renderer> ().material.color = Color.red;
	}

	void OnTriggerStay(){
		transform.Rotate (Vector3.up, Time.deltaTime * 30, Space.World);
	}

	void OnTriggerExit(){
		GetComponent<Renderer> ().material.color = Color.white;
	}
}
