using UnityEngine;
using System.Collections;

public class capsuleNav : MonoBehaviour {
	public float speed = 2.0f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		//ASSIGNMENT VERSION
//		if (Input.GetKey(KeyCode.RightArrow)){
//			transform.position += Vector3.right * speed * Time.deltaTime;
//		}
//		if (Input.GetKey(KeyCode.LeftArrow)){
//			transform.position += Vector3.left* speed * Time.deltaTime;
//		}
//		if (Input.GetKey(KeyCode.UpArrow)){
//			transform.position += Vector3.forward * speed * Time.deltaTime;
//		}
//		if (Input.GetKey(KeyCode.DownArrow)){
//			transform.position += Vector3.back* speed * Time.deltaTime;
//		}

		//float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
		float r = Input.GetAxis("Horizontal") *30.0f;
		transform.Rotate(Vector3.up, r * Time.deltaTime, Space.Self);
		float z = Input.GetAxis ("Vertical") * Time.deltaTime * speed;
		transform.Translate (0, 0, z);
	}
}
