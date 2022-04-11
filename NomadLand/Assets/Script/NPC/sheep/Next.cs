using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next : MonoBehaviour
{
    public int Sad;
    public int opNext=0;
    public GameObject A,B,C;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.transform.position = new Vector3(11111.98f,111111.19f,0);
        A = GameObject.Find("A");
        B = GameObject.Find("B");
        C = GameObject.Find("C");
        A.transform.position = new Vector3(11111f , 11111f ,0);
        B.transform.position = new Vector3(11111f , 11111f ,0);
        C.transform.position = new Vector3(11111f , 11111f ,0);
    }

    // Update is called once per frame
    void Update()
    {
        Sad = GameObject.Find("sheepSad").GetComponent<sadTalk>().sadNext;
        if(Sad==1){
            this.gameObject.transform.position = new Vector3(7.76f,-4.16f,0);
        }
        if(opNext==1){
            A.transform.position = new Vector3(-1.07f,1.3f,0);
            B.transform.position = new Vector3(-0.98f,1.12f,0);
            C.transform.position = new Vector3(-0.98f,0.85f,0);
        }

    }
    void OnMouseDown(){
        opNext++;
    }
}
