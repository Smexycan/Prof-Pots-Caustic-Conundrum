using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SHOOTER : MonoBehaviour
{
	public Rigidbody projectile;
	public float speed = 20;


	void start()
	{
		GameVariables.ammo = 5;

	}
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButtonDown ("Fire1") && GameVariables.ammo>0) 
		{
			GameVariables.ammo--;
			Rigidbody instantiatedProjectile = Instantiate (projectile, transform.position, transform.rotation)as Rigidbody;
			instantiatedProjectile.velocity = transform.TransformDirection (new Vector3 (0, 0, speed));
		}
	}
}