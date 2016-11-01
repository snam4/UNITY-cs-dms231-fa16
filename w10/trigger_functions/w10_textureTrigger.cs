using UnityEngine;
using System.Collections;

public class w10_textureTrigger : MonoBehaviour {
	public Texture orgTexture;
	public Texture repTexture;

	void OnTriggerEnter(){
		GetComponent<Renderer> ().material.mainTexture = repTexture;
	}

	void OnTriggerStay(){
		transform.Rotate (Vector3.up, Time.deltaTime * 30, Space.World);
	}

	void OnTriggerExit(Collider other){
		GetComponent<Renderer> ().material.mainTexture = orgTexture;
	}
}
