using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DB.Utils 
{
    public class instantiator : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    public void Instantiate ()
    {
        GameObject go = Instantiate (_prefab);
        go.transform.position = transform.position;
        go.transform.parent = null ;
    }
}

}
