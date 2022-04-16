using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    [SerializeField] float playerSpeed = 0.0001f;
    Transform playerTransform;
    private void Awake() {
        playerTransform = GetComponent<Transform>();
    }
    void Start()
    {
        
    }

    void Update()
    {
        MovePlayer(playerSpeed);
    }

    private void MovePlayer(float speed)
    {
        if(Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(-speed * Time.deltaTime,0f,0f);
        }
        if(Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(speed * Time.deltaTime,0f,0f);
        }
        if(Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(0f,0f,-speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(0f,0f,speed * Time.deltaTime);
        }
        
    }
}
