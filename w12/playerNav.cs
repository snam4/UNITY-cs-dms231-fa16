using UnityEngine;
using System.Collections;

public class playerNav : MonoBehaviour {
	private float speed = 7.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float r = Input.GetAxis ("Horizontal") *30* Time.deltaTime;
		transform.Rotate (Vector3.up, r , Space.Self);
		float z = Input.GetAxis ("Vertical") *Time.deltaTime*speed;
		transform.Translate (0, 0, z);
	}
}
