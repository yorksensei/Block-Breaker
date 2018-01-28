﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

	static MusicPlayer instance = null;
	// Use this for initialization

	void Awake () {
		if (instance != null) {
			Destroy(gameObject);
			print ("Destroying Music Player");
		}
		else {
			instance = this;
			MusicPlayer.DontDestroyOnLoad (gameObject);
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
