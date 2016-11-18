using UnityEngine;
using System.Collections;

public class coinInstantiate : MonoBehaviour {
	public GameObject coinPrefab;
	GameObject coinClone;
	public Transform pos;
	Vector3 spawn_pos;
	float x,y,z;
	float timer = 0.0f;

	void spawn_coin(){
		x = pos.position.x + Random.Range (-10.0f, 10.0f);
		y = pos.position.y;
		z = pos.position.z + Random.Range (-10.0f, 10.0f);
		spawn_pos = new Vector3(x,y,z);

		coinClone = Instantiate (coinPrefab, spawn_pos, coinPrefab.transform.rotation) as GameObject;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer > 3) {
			spawn_coin ();
			timer = 0.0f;
			print ("coin");
		}
	}
}
