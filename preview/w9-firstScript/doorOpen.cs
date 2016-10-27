using UnityEngine;
using System.Collections;

public class doorOpen : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
//		if (transform.rotation.eulerAngles.y > 0) {
//			transform.Rotate (Vector3.up, Time.deltaTime * -30, Space.World);
//		}
	}
	void OnTriggerStay(Collider other){

		//transform.Translate(Vector3.up * Time.deltaTime, Space.World);
		//print (transform.rotation.eulerAngles.z);
		if (transform.rotation.eulerAngles.y < 90) {
			transform.Rotate (Vector3.up, Time.deltaTime * 30, Space.World);
		}
	}
}
