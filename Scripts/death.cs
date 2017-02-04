using UnityEngine;
using System.Collections;

public class death : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

			if (GameVariables.health < 0)
				Destroy (gameObject);

        if (GameVariables.health > 150)
            GameVariables.health = 150;

	}
}
