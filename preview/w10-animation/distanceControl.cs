//http://answers.unity3d.com/questions/348373/enemy-is-not-stopping-following-the-player.html
//commented : Queternion Look At
using UnityEngine;
using System.Collections;

public class distanceControl : MonoBehaviour {
	public Transform target;
	int moveSpeed =0;
	//int rotationSpeed = 3;
	Transform player;
	float distance  = 7.8f;
	float distanceAttack = 2.6f;
	public Transform myTransform;
	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		myTransform = transform;
		target = GameObject.FindWithTag ("Player").transform;
		anim.SetBool ("inZone", false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance (myTransform.position, target.position) < distance) {
			if (Vector3.Distance (myTransform.position, target.position) > distanceAttack) {
				moveSpeed = 1;
				anim.SetBool ("inZone", true);
				myTransform.LookAt (target);
				//myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
				//Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed*Time.deltaTime);
				myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
			}

			if(Vector3.Distance(myTransform.position, target.position) < distanceAttack){
				moveSpeed = 0;
				anim.SetBool ("inZone", false);
				//GetComponent<Animation>().Play("attack");
			}
		}else{
			moveSpeed = 0;
			anim.SetBool ("inZone", false);
		}
		float d = Vector3.Distance(myTransform.position, target.position);
		print(d);
	}	
}
