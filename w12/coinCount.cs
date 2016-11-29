using UnityEngine;
using System.Collections;

public class coinCount : MonoBehaviour {

	public static int score; //access to this score when using trigger (cannot detect a collision)

	void Update () {
		print (score);
	}

	void OnCollisionEnter(Collision other){
		if (other.collider.tag == "coin") {
			score++;
		}
	}
}
