using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sadTalk : MonoBehaviour
{
    public int Sad;
    public int sadNext=0;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.transform.position = new Vector3(11111.98f,111111.19f,0);
        
    }

    // Update is called once per frame
    void Update()
    {
        Sad = GameObject.Find("dia").GetComponent<dia>().DiaSad;
        if(Sad==1){
            this.gameObject.transform.position = new Vector3(-0.98f,1.19f,0);
            sadNext = 1;
        }
    }
}
