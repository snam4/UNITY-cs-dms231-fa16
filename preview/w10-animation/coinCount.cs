using UnityEngine;
using System.Collections;

public class coinCount : MonoBehaviour {

	public int score;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision other){
		if (other.collider.tag == "coin") {
			score++;
		}
	}
}
