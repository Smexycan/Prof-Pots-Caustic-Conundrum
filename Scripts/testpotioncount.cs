using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class testpotioncount : MonoBehaviour {
	public Text uitext;
	
	// Update is called once per frame
	void Update () {
	
		if (uitext != null) {
			uitext.text = GameVariables.testpotion.ToString ();
	}
}
}
