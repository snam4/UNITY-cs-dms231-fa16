//https://docs.unity3d.com/ScriptReference/GUI.Label.html
using UnityEngine;
using System.Collections;

public class guiDisplay : MonoBehaviour {
	float eHealth = 0.0f;
	float coin = 0.0f;
	GUITexture myTexture;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		eHealth = enemyHealth.eHealth;
		string eHealthText = eHealth.ToString ();

		GUI.Label (new Rect (55, 60, 25, 25), eHealthText);
		GUI.Box (new Rect (10,10, 100, 100),"ENEMY HEALTH");

		coin = coinCount.score;
		string coinText = coin.ToString ();

		GUI.Label (new Rect (170, 60, 25, 25), coinText);
		GUI.Box (new Rect (120,10, 100, 100),"Coin");
	}
}
