//https://www.youtube.com/watch?v=Myl4snsIfhE
using UnityEngine;
using System.Collections;

public class bulletShooting : MonoBehaviour {
	public Transform bullet;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("space")){
			Instantiate(bullet,transform.position, transform.rotation);
		}
	}
}
