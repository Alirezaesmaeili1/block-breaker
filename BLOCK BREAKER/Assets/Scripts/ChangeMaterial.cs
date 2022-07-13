using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public Material New;
    public Material Old;
    void Start()
    {
        GetComponent<MeshRenderer>().materials[0] = Old;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
