using UnityEngine;
using System.Collections;

public class triggerRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up, Time.deltaTime * 30,Space.World);
	}

	void OnTriggerEnter(Collider other){
		//if(other.gameObject.tag == "Player")
		GetComponent<Renderer> ().material.color = Color.red;
	}

	void OnTriggerStay(Collider other){
		//transform.position = new Vector3(0, 0, 0);
		//transform.Translate(Vector3.forward * Time.deltaTime);
		transform.Translate(Vector3.up * Time.deltaTime, Space.World);
	}

	void OnTriggerExit(Collider other){
		GetComponent<Renderer> ().material.color = Color.white;
	}
}
