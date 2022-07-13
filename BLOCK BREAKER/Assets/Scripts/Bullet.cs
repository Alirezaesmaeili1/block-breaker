using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bullet : MonoBehaviour
{   
    Rigidbody Rb;
    public UnityEvent oncollisionEvent;
    public GameObject exteraball;
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
        oncollisionEvent?.Invoke();
        Box box = other.gameObject.GetComponent<Box>();
        if(other.transform.tag=="Enemy"){
            if(box.hits>1){
                box.Brakbrick();
                
            }
            else{
                Destroy(other.gameObject);
            }
        }
        if(other.transform.tag=="ExteraBall"){
            if(box.hits>1){
                box.Brakbrick();
            }
            else{
                int numnewball = Random.Range(2,4);
                  for(int i=0;i<numnewball;i++){
                    GameObject newball = Instantiate(exteraball,transform.position,Quaternion.identity) as GameObject;
                }
                Destroy(other.gameObject);
            }
        }

    }
}

