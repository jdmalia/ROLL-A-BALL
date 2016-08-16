using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// Making it public allows it to be visbile in the Inspector of the Editor
	public float speed;
	public Text countText;
	public Text winText;

	private Rigidbody rb;
	private int count;

	void Start() {

		rb = GetComponent<Rigidbody> ();
		count = 0;
		setCountText ();
		winText.text = "";
	}

	// Called before performing any physics calculations
	void FixedUpdate() {

		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}

	// Called when our player GameObject first touches a trigger collider (other
	void OnTriggerEnter(Collider other) {
		
		if (other.gameObject.CompareTag ("Pick Up")) {
			
			other.gameObject.SetActive (false);
			count++;
			setCountText ();
		}
	}

	void setCountText(){
		countText.text = "Count: " + count.ToString ();
		if (count >= 12) {
			winText.text = "You Win!";
		}
	}
}
