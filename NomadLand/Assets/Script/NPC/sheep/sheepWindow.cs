using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sheepWindow : MonoBehaviour
{
    public GameObject intro;
    public int Move = 0;
    int time = 0;
    public GameObject name;
    // Start is called before the first frame update
    void Start()
    {
        intro = GameObject.Find("sheepIntro");
        name = GameObject.Find("name");
    }

    // Update is called once per frame
    void Update()
    {
        time++;
        if(time>100){
            Move = 1; 
        }
    }
}
