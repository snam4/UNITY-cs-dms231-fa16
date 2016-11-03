using UnityEngine;
using System.Collections;

public class ZombieTriggerWalk : MonoBehaviour {
	Animator anim; 
	void Start(){
		anim = GetComponent<Animator> ();
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			anim.SetBool ("inZone", true);
			print ("inZone");
		}
	}

	void OnTriggerExit(Collider other){
		if (other.gameObject.tag == "Player") {
			anim.SetBool ("inZone", false);
			print ("outZone");
		}
	}
}
