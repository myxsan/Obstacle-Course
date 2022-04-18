using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float spinnerSpeed;
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        this.gameObject.transform.Rotate(0.0f, -spinnerSpeed, 0.0f);
    }
}
