using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class name : MonoBehaviour
{
    public int move;
    public int clicked = 0;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.transform.position = new Vector3(111111f ,11111f ,0);
        move = GameObject.Find("GameObject").GetComponent<sheepWindow>().Move;
    }

    // Update is called once per frame
    void Update()
    {
        move = GameObject.Find("GameObject").GetComponent<sheepWindow>().Move;
        if(move==1){
            this.gameObject.transform.position = new Vector3(-1.06f ,-2f ,0);
        }
        if(clicked==1){
            this.gameObject.transform.position = new Vector3(111111f ,11111f ,0);
        }
    }
    void OnMouseDown(){
        clicked = 1;
        
    }
}
