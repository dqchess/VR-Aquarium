﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class antiAliasing : MonoBehaviour {

	// Use this for initialization
	void Start () {
        XRSettings.eyeTextureResolutionScale = 2.0f;

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}