using UnityEngine;
using System.Collections;

public class zombieDistanceAttack : MonoBehaviour {
	public Transform target;
	public Transform myTransform;

	//int moveSpeed =0;
	Transform player;
	float distanceWalk  = 7.8f;
	float distanceAttack = 2.6f;

	Animator anim;

	void Start () {
		anim = GetComponent<Animator> ();
		myTransform = transform;
		target = GameObject.FindWithTag ("Player").transform;
		anim.SetBool ("inZone", false);
	}
		
	void Update () {
		if (Vector3.Distance (myTransform.position, target.position) < distanceWalk) { 
			if (Vector3.Distance (myTransform.position, target.position) > distanceAttack) { //walk
				
				anim.SetBool ("walk", true);
				anim.SetBool ("attack", false);
				myTransform.LookAt (target);
				//moveSpeed = 1;
				//myTransform.position += myTransform.forward * Time.deltaTime;
			}

			if(Vector3.Distance(myTransform.position, target.position) < distanceAttack){ //attack
				//moveSpeed = 0;
				anim.SetBool ("walk", false);
				anim.SetBool ("attack", true);
			}
		}else{
			//moveSpeed = 0;
			anim.SetBool ("walk", false);
			anim.SetBool ("attack", false);
		}

		float d = Vector3.Distance(myTransform.position, target.position);
		print(d);
	}	
}

