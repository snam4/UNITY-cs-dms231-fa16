//Demo #2
//10-27-16
//Material color - https://docs.unity3d.com/ScriptReference/Material-color.html
//On Trigger Enter - https://docs.unity3d.com/ScriptReference/Collider.OnTriggerEnter.html
//On Trigger Exit - https://docs.unity3d.com/ScriptReference/Collider.OnTriggerExit.html

using UnityEngine;
using System.Collections;

public class MaterialColor : MonoBehaviour {
	void OnTriggerEnter(){
		GetComponent<Renderer> ().material.color = Color.red;
	}

	void OnTriggerExit(){
		GetComponent<Renderer> ().material.color = Color.white;
	}
}

/*EXTRA TIP FOR THIRD PERSON CONTROLLER
1) Start with a suitable scene. There ought to be enough flat ground to walk around on.

2) Place the "ThirdPersonCharacter" prefab in the scene.

3) Unfold the ThirdPersonCharacter hierarchy in the hierarchy window, and delete all child of "ThirdPersonController".

4) Place your own character model as a child of the ThirdPersonCharacter.

5) Drop the Avatar of your model (created by model importer, cf documentation) inside the Avatar slot of the Animator component on "ThirdPersonController"

6) Make sure your character model's position in the inspector is set to zero on X and Z, and that it's Y position is appropriately adjusted so that your character's feet are at the same position as the ThirdPersonCharacter GameObject. (if you find it easier, you could add your character first before deleting Ethan, so that you can use Ethan's feet as a guide for where your character's feet should be)

7) Hit play, and try controlling your character!
*/
