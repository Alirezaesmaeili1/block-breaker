using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{   
    Rigidbody Rb;
    public float BallSpeed = 5f;
    public float ChangeSpeed = 0.01f ;
    void Start() 
    {
        Rb=GetComponent<Rigidbody>(); 
        Rb.velocity = new Vector3(BallSpeed*Time.deltaTime,0,BallSpeed*Time.deltaTime);
    }
    void Update()
    {
       Rb.velocity *=ChangeSpeed;
    }
    private void OnCollisionEnter(Collision other) {
        if(other.transform.tag=="Enemy"){
            Destroy(other.gameObject);
            //gameObject.SetActive(false);
        }
    }
}
