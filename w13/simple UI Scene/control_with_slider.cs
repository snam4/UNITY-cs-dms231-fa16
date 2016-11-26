using UnityEngine;
using System.Collections;

public class control_with_slider : MonoBehaviour {
	float sp =10f;
	void Update () {
		transform.Rotate (Vector3.up, sp * Time.deltaTime, Space.World);
	}

	public void SpeedControl(float newSp){
		sp = newSp*30f;
	}
}
