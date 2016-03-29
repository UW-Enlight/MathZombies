﻿using UnityEngine;
using System.Collections;

public class RotateZombies : MonoBehaviour {

    public Transform target;

	void Awake(){
		
	}
    void Update()
    {
        // Rotate the camera every frame so it keeps looking at the target 
        transform.LookAt(target);
    }

}