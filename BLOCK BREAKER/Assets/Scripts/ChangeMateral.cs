using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMateral : MonoBehaviour
{
    public Renderer rend ;
    public Material New;
    public GameManager gm;
    void Start()
    {
        rend = GetComponent<Renderer>();
    }
    void Update()
    {
           
    }
    private void OnCollisionEnter(Collision other) {
         Box box = other.gameObject.GetComponent<Box>();
        if(other.transform.tag=="Ball"){
            if(box.hits>1){
                box.Brakbrick();
                rend.material=New;
            }
            else{
                gm.ChangeScore(box.points);
                Destroy(other.gameObject);
            }

        }
    }
}
