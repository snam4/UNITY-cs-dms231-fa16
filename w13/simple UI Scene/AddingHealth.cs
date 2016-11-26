	using UnityEngine;
using System.Collections;

public class AddingHealth : MonoBehaviour {
	void Start () {
	
	}

	void OnMouseDown () {
		SendingDataToSlideBar.health += 5;
	}
}
