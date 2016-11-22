using UnityEngine;
using System.Collections;

public class cameraDistanceWithSlider : MonoBehaviour {
	float sp =10f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up, sp * Time.deltaTime, Space.World);
	}

	public void SpeedControl(float newSp){
		sp = newSp*30f;
	}
}
