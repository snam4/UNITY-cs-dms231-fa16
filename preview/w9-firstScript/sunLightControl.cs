using UnityEngine;
using System.Collections;

public class sunLightControl : MonoBehaviour {
	public GameObject sun;
	private Color c = new Color(.5f, .0f, .0f);
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(){
		sun.GetComponent<Light>().intensity = 0.7f;
		sun.GetComponent<Light> ().color = c;
	}

	void OnTriggerExit(){
		sun.GetComponent<Light>().intensity = 1.1f;
		sun.GetComponent<Light> ().color = new Color(1,1, 1);
	}
}
