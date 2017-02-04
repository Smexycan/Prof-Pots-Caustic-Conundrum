using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class testpotionshooter : MonoBehaviour
{
	public Rigidbody projectile;
	public float speed = 20;


	void start()
	{
		GameVariables.testpotion = 0;

	}
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Q) && GameVariables.testpotion>0) 
		{
			GameVariables.testpotion--;
			Rigidbody instantiatedProjectile = Instantiate (projectile, transform.position, transform.rotation)as Rigidbody;
			instantiatedProjectile.velocity = transform.TransformDirection (new Vector3 (0, 0, speed));
		}
	}
}