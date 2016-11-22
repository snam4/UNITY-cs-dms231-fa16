using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class sceneChange : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other){
		SceneManager.LoadScene (0);
		print ("enter");
	}
}
