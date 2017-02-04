using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Ammunition : MonoBehaviour {

	void OnTriggerEnter (Collider collider){
		if (collider.gameObject.name == "player") {
			GameVariables.ammo += 5;
			GameVariables.ammocount += 5;
			Destroy (gameObject);
		}
	}


}
