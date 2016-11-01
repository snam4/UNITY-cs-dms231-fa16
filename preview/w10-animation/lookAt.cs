using UnityEngine;
using System.Collections;

public class lookAt : MonoBehaviour {
	public Transform target; //Assign the target in the inspector
	
	void Update () {
		transform.LookAt (target);
	}
}
