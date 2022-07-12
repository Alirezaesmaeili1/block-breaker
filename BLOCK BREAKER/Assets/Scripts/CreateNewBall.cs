using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewBall : MonoBehaviour
{
    public GameObject exteraball ;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int numnewball = Random.Range(2,4);
    private void OnCollisionEnter(Collision other) {
        Box box = other.gameObject.GetComponent<Box>();
            if(other.transform.tag=="Ball"&&box.hits<=1){
                for(int i=0;i<numnewball;i++){
                    GameObject newball = Instantiate(exteraball,transform.position,Quaternion.identity) as GameObject ;
                }
            }
    }
}
