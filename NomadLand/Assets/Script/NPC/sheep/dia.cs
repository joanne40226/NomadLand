using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dia : MonoBehaviour
{
    public int next;
    public int DiaSad = 0;
    int timeCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.transform.position = new Vector3(-111112.3f, 111112.0f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        next = GameObject.Find("yes").GetComponent<confirm>().Next;
        if(next==1){
            timeCount++;
        }
        if(timeCount>50){
            this.gameObject.transform.position = new Vector3(1.71f, 5.31f, 0);
            if(timeCount>100){
                DiaSad = 1;
            }
        }
    }
}
