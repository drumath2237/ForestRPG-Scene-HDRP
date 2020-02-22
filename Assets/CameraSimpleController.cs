using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class CameraSimpleController : MonoBehaviour
{
    [FormerlySerializedAs("_speed")] [SerializeField] private float speed;
    [SerializeField] private bool isAnimated;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isAnimated = !isAnimated;
        }

        if (isAnimated)
        {
            var transform1 = transform;
            transform1.position += transform1.forward * speed;
        }

    }
}
