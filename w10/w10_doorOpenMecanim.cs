using UnityEngine;
using System.Collections;

public class w10_doorOpenMecanim : MonoBehaviour {
	Animator anim;

	void Start(){
		anim = GetComponent<Animator> ();
	}
	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "Player"){
			anim.SetBool ("open", true);
			anim.SetBool ("close", false);
		}
	}

	void OnTriggerExit(Collider other){
		if(other.gameObject.tag == "Player"){
			anim.SetBool ("open", false);
			anim.SetBool ("close", true);
		}
	}
}
