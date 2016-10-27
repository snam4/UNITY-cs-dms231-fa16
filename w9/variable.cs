//Demo #1
//10-27-16
//https://unity3d.com/learn/tutorials/topics/scripting/data-types
using UnityEngine;
using System.Collections;

public class variable : MonoBehaviour {
	
	//data type
	//1) Value : int, float, double, bool, char, Structs(Vector3, Quaternion)
	//2) Reference : Classes (Transform, GameObject)

	Vector3 pos;
	Transform tran;
	// Use this for initialization
	void Start () {
		//Value type variable
		pos = transform.position;
		pos = new Vector3(0, 2, 0);

		//Reference type variable
		tran = transform;
		tran.position = new Vector3(0, 2, 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
