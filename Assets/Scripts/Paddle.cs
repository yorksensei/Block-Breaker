using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	float mousePosInBlocks = 0;
	Vector3 paddlePos = new Vector3(0.5f,0.5f,0f);
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		mousePosInBlocks = (Input.mousePosition.x / Screen.width * 16);

		/*
		if (paddlePos.x < 0.5f) {
			paddlePos.x = 0.5f;
		} else if (paddlePos.x > 15.5f) {
			paddlePos.x = 15.5f;
		} */

		paddlePos.x = Mathf.Clamp (mousePosInBlocks, 0.5f, 15.5f);

		this.transform.position = paddlePos;
	}
}
