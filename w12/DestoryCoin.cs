using UnityEngine;
using System.Collections;
//Destroy : https://unity3d.com/learn/tutorials/topics/scripting/destroy
public class DestoryCoin : MonoBehaviour {
	public int cCount;

	void OnTriggerEnter(Collider other){
		Destroy (gameObject);
		//coinCount.score++;
	}

//COLLISION METHOD - PHISICS PROBLEM
//	void OnCollisionEnter(Collision other){
//		Debug.Log ("collide");
//		Destroy (gameObject);
//	}
}
