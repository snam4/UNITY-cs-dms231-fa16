using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class sceneChange : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		SceneManager.LoadScene (1);
		print("enter");
		}
}
