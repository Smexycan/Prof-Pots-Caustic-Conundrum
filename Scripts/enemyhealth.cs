using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class enemyhealth: MonoBehaviour {

	public int damage = 5;
    public int objecthealth = 100;


	void OnTriggerEnter (Collider collider){

		if (collider.gameObject.name == "player") {
			GameVariables.health -= damage;
		}
		{

            if (collider.gameObject.tag == "potion") {
                objecthealth -= GameVariables.testpotiondamage;
                if (objecthealth <1)
                Destroy(gameObject);
            }

		}

	}
}