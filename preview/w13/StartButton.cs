using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour {

	// Use this for initialization
	public void OnStart(){
		//Debug.Log ("Clicked!");
		SceneManager.LoadScene (1);
	}

	public void OnExit(){
		//Debug.Log ("Exit Clicked!");
		Application.Quit();
	}
}
