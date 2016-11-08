using UnityEngine;
using System.Collections;

public class KeyPickUp : MonoBehaviour {
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
	void OnTriggerEnter(Collider other){
		if (other.gameObject == player) {
			playerInventory.hasKey = true;
			Destroy (gameObject);
		}
	}
}