using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   
    Transform playerTransform;
    [SerializeField] float playerSpeed;


    void Start()
    {

    }

    void Update()
    {
        float playerXSpeed = Input.GetAxis("Horizontal") * Time.deltaTime * playerSpeed;
        float playerZSpeed = Input.GetAxis("Vertical") * Time.deltaTime * playerSpeed;
        this.transform.Translate(playerXSpeed, 0.0f, playerZSpeed);
    }
}