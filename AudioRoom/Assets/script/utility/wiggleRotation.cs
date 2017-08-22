using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wiggleRotation : MonoBehaviour
{
    public Vector3 wiggleAmplitude;
    public Vector3 wiggleSpeed;
    public bool randomizeStart;

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

        transform.localEulerAngles = originalEuler + (new Vector3(wiggleAmplitude.x * Mathf.Cos(randomOffset + Time.time * wiggleSpeed.x), wiggleAmplitude.y * Mathf.Cos(randomOffset + Time.time * wiggleSpeed.y), wiggleAmplitude.z * Mathf.Cos(randomOffset + Time.time * wiggleSpeed.z)));
    }
}