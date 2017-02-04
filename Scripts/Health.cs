using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Health: MonoBehaviour {

	public int damage = 5;


	void OnTriggerEnter (Collider collider){

		if (collider.gameObject.name == "player") {
			GameVariables.health -= damage;
		}
		{
			if (collider.gameObject.name == "enemy") {
				GameVariables.enemyhealth -= damage;
				Destroy (gameObject);
			}

		}

	}
}