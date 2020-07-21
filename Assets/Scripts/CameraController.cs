using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Vector3 cameraOffset;
  
    private Transform playerTransform;

    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 0.5f;
    
    

    void Start()
    {
        cameraOffset = transform.position - playerTransform.position;
    }

    void Update()
    {
        Vector3 newPossition = playerTransform.position + cameraOffset;

        transform.position = Vector3.Slerp(transform.position, newPossition, SmoothFactor);
    }
}
