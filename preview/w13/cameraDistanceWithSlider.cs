using UnityEngine;
using System.Collections;

public class cameraDistanceWithSlider : MonoBehaviour {
	float sp =0.0f;

	// Use this for initialization
	void Start () {

	}

	// Camera Rotation Control
	//void Update () {
	//	transform.Rotate (Vector3.up, sp * Time.deltaTime, Space.World);
	//}
	//public void SpeedControl(float newSp){
	//	sp = newSp*30f;
	//}
	//Camera 
	void Update () {
		transform.Translate(Vector3.up*sp, Space.World);
	}
	public void SpeedControl(float newSp){
		sp = newSp * Time.deltaTime;
	}
}
