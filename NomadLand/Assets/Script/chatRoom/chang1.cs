﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chang1 : MonoBehaviour
{
    public int chang;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.transform.position = new Vector3(11111f, 11111f,0 );        
    }

    // Update is called once per frame
    void Update()
    {
        chang = GameObject.Find("background").GetComponent<chatRoom>().ChangDia;
        if(chang==1){
            this.gameObject.transform.position = new Vector3(-4.48f, 3.7f,0 );
        }
    }
}
