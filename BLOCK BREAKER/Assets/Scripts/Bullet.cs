using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{   
    Rigidbody Rb;
    public float BallSpeed = 5f;
    public float MaxSpeed = 20f;
    
   
    void Start() 
    {
        Rb = GetComponent<Rigidbody>();
        Rb.velocity = new Vector3(BallSpeed*Time.deltaTime,0,BallSpeed*Time.deltaTime);
    }
    void FixedUpdate()
    {   
        Rb.velocity *= MaxSpeed ;
    }
    private void OnCollisionEnter(Collision other) {
        if(other.transform.tag=="Enemy"){
            Destroy(other.gameObject);
        }
    }
}
