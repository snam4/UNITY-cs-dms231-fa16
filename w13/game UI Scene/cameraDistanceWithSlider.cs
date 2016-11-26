using UnityEngine;
using System.Collections;

public class cameraDistanceWithSlider : MonoBehaviour {
	float sp =10f;

	//Camera rotation
	/*
	void Update () {
		transform.Rotate (Vector3.up, sp * Time.deltaTime, Space.World);
	}

	public void SpeedControl(float newSp){
		sp = newSp*30f;
	}
	*/

	//Camera position
	void Update () {
		transform.Translate(Vector3.up*sp, Space.World);
	}
	
	public void SpeedControl(float newSp){
		sp = newSp * Time.deltaTime;
	}
}
