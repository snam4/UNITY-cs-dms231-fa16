using UnityEngine;
using System.Collections;

public class doorOpenMecanim : MonoBehaviour {
	Animator anim; 
	void Start(){
		anim = GetComponent<Animator> ();
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			anim.SetBool ("open", true);
			anim.SetBool ("close", false);
		}
	}

	void OnTriggerExit(Collider other){
		if (other.gameObject.tag == "Player") {
			anim.SetBool ("close", true);
			anim.SetBool ("open", false);
		}
	}
}
