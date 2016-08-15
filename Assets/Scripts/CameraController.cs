using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// LateUpdate() is best for follow cameras, procedural animation, and gathering last known info
	// guaranteed to run after Update() is complete
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
