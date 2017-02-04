using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class testpotiondamage: MonoBehaviour {

	public int damage = 5;


	void OnTriggerEnter (Collider collider){

		if (collider.gameObject.name == "player") {
			GameVariables.health += 0;
		}
		{
			if (collider.gameObject.tag == "enemy") {
				GameVariables.enemyhealth -= damage;
                GameObject prefab = Resources.Load("Explosion") as GameObject;
                GameObject explosion = Instantiate(prefab) as GameObject;
                explosion.transform.position = transform.position;
                Destroy(explosion, 1);
                Destroy (gameObject);
			}

		}

	}
}