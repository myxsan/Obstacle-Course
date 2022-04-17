using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitScore : MonoBehaviour
{
    public int hitTimes = 0;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        hitTimes ++;
        Debug.Log("You've bumped into an obstacle " + hitTimes + "X times.");
        
    }

}
