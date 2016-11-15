using UnityEngine;
using System.Collections;

public class enemyHealth : MonoBehaviour {
	public static float eHealth = 5.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (eHealth == 0.0) {
			Destroy (gameObject);
		}

	}
	void OnCollisionEnter(Collision bullet){
		if(bullet.transform.name == ("bullet(Clone)")){
			eHealth -= 1.0f;
		}
		print (eHealth);
	}
	
}
