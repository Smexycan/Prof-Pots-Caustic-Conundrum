using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Ammocountfinal : MonoBehaviour {
	public Text uitext;
	
	// Update is called once per frame
	void Update () {
	
		if (uitext != null) {
			uitext.text = GameVariables.ammo.ToString ();
	}
}
}
