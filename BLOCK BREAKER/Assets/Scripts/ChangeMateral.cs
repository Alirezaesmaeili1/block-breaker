using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMateral : MonoBehaviour
{
    public Material Old;
    public Material New;
    void Start()
    {
        GetComponent<MeshRenderer>().materials[0]=Old;
    }
    void Update()
    {
        
    }
    public void changemat(){
        GetComponent<MeshRenderer>().materials[0]=New;
    }
}
