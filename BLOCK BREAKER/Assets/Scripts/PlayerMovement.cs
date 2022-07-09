using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   
   // public Rigidbody Rb;
    public float PlayerSpeed = 20 ; 
    public Rigidbody rb;
    void Start()
    {
        
    }
    void FixedUpdate() 
    {
        if(Input.GetKey("a"))
        {
            rb.velocity=( new Vector3(-PlayerSpeed,0,0));
        }
        if(Input.GetKey("d"))
        {
           rb.velocity=( new Vector3(PlayerSpeed,0,0));
        }
    }
}
