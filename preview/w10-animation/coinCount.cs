using UnityEngine;
using System.Collections;
//Add this to the character
public class coinCount : MonoBehaviour {

	public int score;

	void OnCollisionEnter(Collision other){
		if (other.collider.tag == "coin") {
			score++;
		}
	}
}
