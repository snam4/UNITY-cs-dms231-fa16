//Demo #2
//10-27-16
//https://docs.unity3d.com/ScriptReference/Transform.Rotate.html
using UnityEngine;
using System.Collections;

public class rotateAndTranslate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.up, Time.deltaTime * 30,Space.World);
		transform.Translate(Vector3.up * Time.deltaTime, Space.World);
	}
}
