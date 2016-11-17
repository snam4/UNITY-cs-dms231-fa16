using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class cannonGameSceneCanvas : MonoBehaviour {
	public float eHealth;
	public Slider eHealthBar;
	public Text eHealthText;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		eHealth = enemyHealth.eHealth;
		eHealthBar.value = eHealth;
		eHealthText.text = "Health : " + eHealth;
	}
}
