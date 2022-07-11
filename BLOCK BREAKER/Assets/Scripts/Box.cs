using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public int points ;
    public int hits ;
    public Sprite hitsprite ;

    public void Brakbrick(){
        hits--;
        GetComponent<SpriteRenderer>().sprite = hitsprite ;
    }

}
