using UnityEngine;
using System.Collections;

public class guiDisplay : MonoBehaviour {
	float eH = 0.0f;
	float coin = 0.0f;

	void OnGUI(){
		eH = enemyHealth.eHealth; 
		string eHText = eH.ToString ();
		GUI.Label (new Rect (55, 60, 25, 25), eHText);
		GUI.Box (new Rect (10, 10, 100, 100), "Enemy Health");

		coin = coinCount.score; 
		string coinText = coin.ToString ();
		GUI.Label (new Rect (155, 60, 25, 25), coinText);
		GUI.Box (new Rect (120, 10, 100, 100), "Coin");
	}
}
