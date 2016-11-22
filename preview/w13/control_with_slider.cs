using UnityEngine;
using System.Collections;

public class control_with_slider : MonoBehaviour {
	float sp =10f;

	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up, sp * Time.deltaTime, Space.World);
		print (sp);
	}

	public void SpeedControl(float newSp){
		sp = newSp*30f;
	}
}
