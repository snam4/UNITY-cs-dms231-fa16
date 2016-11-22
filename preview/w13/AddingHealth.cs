	using UnityEngine;
using System.Collections;

public class AddingHealth : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnMouseDown () {
		SendingDataToSlideBar.health += 5;
		print ("sweet!");
	}
}
