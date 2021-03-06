﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateMe : MonoBehaviour
{
    public bool randomizeStart;
    public Vector3 rotate;

    private Vector3 originalEuler;
    private float randomOffset = 1.0f;

    private bool doOnceFlag = true;

    void Awake()
    {
        if (randomizeStart)
        {
            randomOffset = Random.Range(0.0f, 360.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (doOnceFlag)
        {
            originalEuler = transform.localEulerAngles;
            doOnceFlag = false;
        }

        transform.Rotate(rotate);
    }
}