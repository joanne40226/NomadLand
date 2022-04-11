using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chatRoom : MonoBehaviour
{
    int timeCount = 0;
    public int ChangDia = 0;
    public int Player = 0;
    public GameObject chang2;
    public GameObject chang3;
    public GameObject player2;
    // Start is called before the first frame update
    void Start()
    {
        chang2 = GameObject.Find("chang2");
        chang2.transform.position = new Vector3(1111f , 1111f ,0);   
        player2 = GameObject.Find("player2");
        player2.transform.position = new Vector3(1111f , 1111f ,0);  
        chang3 = GameObject.Find("chang3");
        chang3.transform.position = new Vector3(1111f , 1111f ,0);  
    }

    // Update is called once per frame
    void Update()
    {
        timeCount++;
        if(timeCount>100){
            ChangDia = 1;
        }
        if(timeCount>=300){
            Player = 1;
        }
        if(timeCount>=500){
            chang2.transform.position = new Vector3(-2.1f , 0.51f ,0);   
        }
        if(timeCount>=700){
            player2.transform.position = new Vector3(5.22f , -1.1f ,0);   
        }
        if(timeCount>=900){
            chang3.transform.position = new Vector3(-1.04f , -3.34f ,0);   
        }


    }
}
