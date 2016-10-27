using UnityEngine;
using System.Collections;

public class TextureSwap : MonoBehaviour {
	public GameObject triggerTarget;
	public Texture orgTexture;
	public Texture repTexture;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		triggerTarget.GetComponent<Renderer>().material.mainTexture = repTexture;
	}
	void OnTriggerExit(Collider other){
		triggerTarget.GetComponent<Renderer>().material.mainTexture = orgTexture;
	}
}

//var triggerTarget : GameObject; //model to change
//var originalTex : Texture;
//var replacementTex : Texture;
//function OnTriggerEnter(other : Collider){
//	triggerTarget.renderer.material.mainTexture = replacementTex;
//}
//function OnTriggerExit(other : Collider){
//	triggerTarget.renderer.material.mainTexture = originalTex;
//}
