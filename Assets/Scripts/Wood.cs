using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : MonoBehaviour
{
    public static Wood instance;
    public GameObject wood;
    public float speed = 3f;

    void OnDisable()
    {
        instance = null;
    }

    void makeInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Awake()
    {
        makeInstance();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(0f, speed, 0f);
        
    }
}
