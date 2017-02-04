using UnityEngine;
using System.Collections;

public class PickupObejectTwk : MonoBehaviour {
	GameObject grabbedObject;
	float grabbedObjectSize;

	Vector3 PreviousGrabPosition;

	GameObject GetMouseHoverObject(float range)
	{
		int x = Screen.width / 2;
		int y = Screen.height / 2;

		Vector3 position = gameObject.transform.position;
		Ray ray = Camera.main.GetComponent<Camera>().ScreenPointToRay (new Vector3 (x, y));
		RaycastHit raycastHit;
		Vector3 target = position + Camera.main.transform.forward * range;
		if (Physics.Raycast (ray, out raycastHit))
			return raycastHit.collider.gameObject;
		return null;

	}

	void TryGrabObject(GameObject grabObject)
	{
		if (grabObject == null || !CanGrab(grabObject))
			return;

		grabbedObject = grabObject;
		grabbedObjectSize = grabObject.GetComponent<Renderer>().bounds.size.magnitude;
		grabbedObject.GetComponent<Rigidbody> ().useGravity = false;
	}

	bool CanGrab(GameObject candidate)
	{
		return candidate.GetComponent<Pickupable> () != null;
	}

	void DropObject()
	{
		if (grabbedObject == null )
			return;


		Rigidbody rb = grabbedObject.GetComponent<Rigidbody> ();
		if (rb != null) 
		{
			Vector3 throwvector = grabbedObject.transform.position - PreviousGrabPosition;
			float speed = throwvector.magnitude / Time.deltaTime;
			Vector3 throwVelocity = speed * throwvector.normalized;
			rb.velocity = throwVelocity;
			grabbedObject.GetComponent<Rigidbody> ().useGravity = true;
		}
		grabbedObject = null;

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.E)) {

			if (grabbedObject == null)
				TryGrabObject (GetMouseHoverObject (5));
			else
				DropObject ();
		}
		if (grabbedObject != null) {		

			PreviousGrabPosition = grabbedObject.transform.position;
			Vector3 newPosition = gameObject.transform.position + Camera.main.transform.forward * 1;
			grabbedObject.transform.position = newPosition;

		}
	}
}
