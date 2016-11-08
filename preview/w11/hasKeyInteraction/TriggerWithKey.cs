using UnityEngine;
using System.Collections;

public class TriggerWithKey : MonoBehaviour {
	private GameObject player;
	private PlayerInventory playerInventory;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		playerInventory = player.GetComponent<PlayerInventory> ();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter (Collider other){
		if (other.gameObject.tag == "Player") {
			if (playerInventory.hasKey == true) {
				GetComponent<Renderer> ().material.color = Color.red;
				Debug.Log ("Has a Key!");
			}
		}
	}
	void OnTriggerStay (Collider other){
		if (other.gameObject.tag == "Player") {
			if (playerInventory.hasKey == true) {
				transform.Rotate (Vector3.up, Time.deltaTime * 30, Space.World);
			}
		}
	}
	void OnTriggerExit (Collider other){
		if (other.gameObject.tag == "Player") {
			if (playerInventory.hasKey == true) {
				GetComponent<Renderer> ().material.color = Color.white;
			}
		}
	}
}
