using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class testpotionUIswitch : MonoBehaviour {

    public Text potiontext;
    public Image potionimage;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        foreach (Transform child in this.transform)
        {
            if (GameVariables.testpotion < 0)
            {
                child.gameObject.SetActive(false);
            }
            else if (GameVariables.testpotion > 0)
            {
                child.gameObject.SetActive(true);
            }
        }

    }
}
