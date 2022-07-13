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
          transform.Translate(new Vector3(-PlayerSpeed*Time.deltaTime,0,0));
        }
        if(Input.GetKey("d"))
        {
           transform.Translate(new Vector3(PlayerSpeed*Time.deltaTime,0,0));
        }
        if(Input.GetKey("w")){
          transform.Translate(new Vector3(0,0,PlayerSpeed*Time.deltaTime));
        }
         if(Input.GetKey("s")){
          transform.Translate(new Vector3(0,0,-PlayerSpeed*Time.deltaTime));
        }
    }
}
