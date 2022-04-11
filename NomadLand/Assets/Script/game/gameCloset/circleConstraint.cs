using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleConstraint : MonoBehaviour
{
    GameObject circle1, circle2, circle3, circle4, circle5;
    // Start is called before the first frame update
    void Start()
    {
        circle1 = GameObject.Find("circle1");
        circle2 = GameObject.Find("circle2");
        circle3 = GameObject.Find("circle3");
        circle4 = GameObject.Find("circle4");
        circle5 = GameObject.Find("circle5");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
