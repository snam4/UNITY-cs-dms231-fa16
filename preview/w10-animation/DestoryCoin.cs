using UnityEngine;
using System.Collections;
//Destroy : https://unity3d.com/learn/tutorials/topics/scripting/destroy
public class DestoryCoin : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
//		if(Input.GetKey(KeyCode.Space))
//		{
//			Destroy(gameObject);
//		}
	}

	void OnCollisionEnter(Collision other){
		Debug.Log ("collide");
		Destroy (gameObject);
	}
}
