﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyThings : MonoBehaviour {

	// Use this for initialization
	void Awake () {
        DontDestroyOnLoad(this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
