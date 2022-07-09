using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   
    
    public float PlayerSpeed = 20 ; 
    public Rigidbody rb;
    void Start()
    {
        
    }
    void FixedUpdate() 
    {
        if(Input.GetKey("a"))
        {
           rb.AddForce(new Vector3(-PlayerSpeed*Time.deltaTime,0,0),ForceMode.Impulse);
        }
        if(Input.GetKey("d"))
        {
           rb.AddForce(new Vector3(PlayerSpeed*Time.deltaTime,0,0),ForceMode.Impulse);
        }
    }
}
