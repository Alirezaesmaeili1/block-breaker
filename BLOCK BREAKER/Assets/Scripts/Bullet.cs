using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{   
    Rigidbody Rb;
    public float BallSpeed = 5f;
    void Start() 
    {
        Rb=GetComponent<Rigidbody>();
        Rb.AddForce(new Vector3(BallSpeed*Time.deltaTime,0,BallSpeed*Time.deltaTime),ForceMode.Impulse);
    }
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other) {
        if(other.transform.tag=="Enemy"){
            Destroy(other.gameObject);
            //gameObject.SetActive(false);
        }
    }
}
