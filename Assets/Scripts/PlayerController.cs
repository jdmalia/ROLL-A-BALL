using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// Making it public allows it to be visbile in the Inspector of the Editor
	public float speed;

	private Rigidbody rb;

	void Start() {

		rb = GetComponent<Rigidbody> ();
	}

	// Called before performing any physics calculations
	void FixedUpdate() {

		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}
}
