using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pm : MonoBehaviour
{
   
    public float PlayerSpeed = 20 ; 
    public Rigidbody rb;
  
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
        if(Input.GetKey("w"))
        {
           rb.AddForce(new Vector3(0,0,PlayerSpeed*Time.deltaTime),ForceMode.Impulse);
        }
        if(Input.GetKey("s"))
        {
           rb.AddForce(new Vector3(0,0,-PlayerSpeed*Time.deltaTime),ForceMode.Impulse);
        }
        
    }
}
