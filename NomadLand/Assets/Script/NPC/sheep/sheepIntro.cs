using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sheepIntro : MonoBehaviour
{
    public int move;
    public int next;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.transform.position = new Vector3(-4.1f ,8.4f ,0);
    }

    // Update is called once per frame
    void Update()
    {
        move = GameObject.Find("GameObject").GetComponent<sheepWindow>().Move;
        next = GameObject.Find("yes").GetComponent<confirm>().Next;
        if(move==1){
            this.gameObject.transform.position = new Vector3(-0.083f ,-2.65f ,0);   
        }
        if(next==1){
            this.gameObject.SetActive(false);
        }          
        
             
    }
}
