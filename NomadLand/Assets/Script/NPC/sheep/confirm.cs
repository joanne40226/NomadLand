using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class confirm : MonoBehaviour
{
    public int Next = 0;
    public GameObject nameInputField;
    public int clicked;
    
    // Start is called before the first frame update
    void Start()
    {
        nameInputField = GameObject.Find("InputField");
        nameInputField.transform.position = new Vector3(11111f , 11111f ,0);
        this.gameObject.transform.position = new Vector3(11111f ,11111f ,0);
    }

    // Update is called once per frame
    void Update()
    {
        nameInputField = GameObject.Find("InputField");
        clicked = GameObject.Find("Name").GetComponent<name>().clicked;
        if(clicked==1){
            this.gameObject.transform.position = new Vector3(-0.93f , -2.84f ,0);   
            nameInputField.transform.position = new Vector3(600f , 230f ,0);   
        }          
        if(Next==1){
            nameInputField.transform.position = new Vector3(11111f , 11111f ,0);
            this.gameObject.transform.position = new Vector3(11111f ,11111f ,0);
        }
    }
    void OnMouseDown(){
        Next = 1;
    }
}
