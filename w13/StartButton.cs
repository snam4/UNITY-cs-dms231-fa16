using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour {


	public void OnStart(){
		SceneManager.LoadScene (1);
	}

	public void OnExit(){
		Application.Quit();
	}
}
