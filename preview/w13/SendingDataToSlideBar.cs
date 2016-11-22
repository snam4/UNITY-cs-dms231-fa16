using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SendingDataToSlideBar : MonoBehaviour {
	public static int health = 100;
	//public GameObject player;
	public Slider healthBar;
	public Text healthText;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("ReduceHealth", 1, 1);
	}

	void ReduceHealth(){
		if (health > 0) {
			health = health - 20;
		}
		healthBar.value = health;
		healthText.text = "Health : " + health;
	}
}
