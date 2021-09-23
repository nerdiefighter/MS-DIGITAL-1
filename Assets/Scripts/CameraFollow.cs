﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//PURPOSE: Camera Will Follow Player in a flowy kind of movement 
//USAGE: attatch this to the MainCamera

// rework this to be smooth like platformer project

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    private void LateUpdate()
    {
        if (target.position.y > transform.position.y) 
        {
            Vector3 newPosition = new Vector3(transform.position.x, target.position.y, transform.position.z);
            transform.position = newPosition;
        }
    }
}
