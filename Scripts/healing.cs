using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class healing : MonoBehaviour {

	void OnTriggerEnter (Collider collider){
		if (collider.gameObject.name == "player") {
			GameVariables.health += 15;
			Destroy (gameObject);

			if (GameVariables.health > 100)
				GameVariables.health = 100;
		}
	}


}
