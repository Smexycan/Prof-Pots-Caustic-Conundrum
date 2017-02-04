using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class testpotionpickup : MonoBehaviour {

	void OnTriggerEnter (Collider collider){
		if (collider.gameObject.name == "player") {
			GameVariables.testpotion += 4;
			Destroy (gameObject);
		}
	}


}
