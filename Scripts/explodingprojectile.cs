using UnityEngine;
using System.Collections;

public class explodingprojectile : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnCollisionEnter (Collision collision) {

       
            GameObject prefab = Resources.Load("Explosion") as GameObject;
            GameObject explosion = Instantiate(prefab) as GameObject;
            explosion.transform.position = transform.position;

            Destroy(explosion, 1);
            Destroy(gameObject);
    }
}
