using UnityEngine;
using System.Collections;

public class Lifetime : MonoBehaviour {

	public float lifetime = 2.0f;
	public float shrink = 0.0f;

	void Awake()
	{
		Destroy (gameObject, lifetime);
	}
}