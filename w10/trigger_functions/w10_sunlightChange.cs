using UnityEngine;
using System.Collections;

public class w10_sunlightChange : MonoBehaviour {
	public GameObject sun;
	private Color c = new Color (.5f, 0.0f, 0.0f);

	void OnTriggerEnter(){
		sun.GetComponent<Light> ().intensity = 0.7f;
		sun.GetComponent<Light> ().color = c;
	}

	void OnTriggerExit(){
		sun.GetComponent<Light> ().intensity = 1.0f;
		sun.GetComponent<Light> ().color = new Color(1,1,1);
	}
}
