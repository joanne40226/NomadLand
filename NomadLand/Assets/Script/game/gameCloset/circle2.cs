using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circle2 : MonoBehaviour
{
    GameObject cou = GameObject.Find("circle10");
    public int c ;
    void Start(){

    }
    void Update(){
        c = cou.GetComponent<counter>().count;        
    }
    void OnMouseDown(){
        
    }
}
