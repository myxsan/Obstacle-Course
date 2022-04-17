using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        Debug.Log(Time.time);
        if (Time.time >= 3)
        {
            GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
