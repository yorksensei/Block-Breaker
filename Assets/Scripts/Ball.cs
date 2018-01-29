using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	public Paddle paddle;

	private Vector3 paddleToBallVector;

	private bool hasStarted = false;

	// Use this for initialization
	void Start () {
		this.GetComponents<Rigidbody2D> ();
		paddleToBallVector = this.transform.position - paddle.transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {

		if (!hasStarted) {
			this.transform.position = paddle.transform.position + paddleToBallVector;
		}	 

		if (Input.GetMouseButtonDown (0)) {
			hasStarted = true;
			gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (2f, 10f);
		}
	}
}
