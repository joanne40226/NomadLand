﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeDialogue : MonoBehaviour
{
    int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        if(i>300){
            this.gameObject.transform.position = new Vector3( 1.5f, -0.9f, 0);
        }
    }
}
