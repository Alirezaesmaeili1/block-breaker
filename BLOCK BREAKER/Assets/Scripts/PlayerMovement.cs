using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   
   // public Rigidbody Rb;
    public float PlayerSpeed = 20 ; 
    void Start()
    {
        
    }
    void FixedUpdate() 
    {
        if(Input.GetKey("a"))
        {
            transform.Translate(new Vector3(-PlayerSpeed*Time.deltaTime,0,0));
        }
        if(Input.GetKey("d"))
        {
            transform.Translate(new Vector3(PlayerSpeed*Time.deltaTime,0,0));
        }
    }
}
