using UnityEngine;
using System.Collections;

public class AmmoON : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		if (GameVariables.ammo < 1) {
			gameObject.SetActive (false);
		}

		if (GameVariables.ammo > 1) {
			gameObject.SetActive (true);

		}
	}
	
	// Update is called once per frame
	void Update () {
	
		if (GameVariables.ammo > 1) {
			gameObject.SetActive (true);
		}
	}
	}