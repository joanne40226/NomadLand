using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chang : MonoBehaviour
{
    public Vector2 vec2 = new Vector2(1,0);
    float moveSpeed = 5f;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        this.gameObject.transform.position = new Vector2(-12.0f, -3.3f);
    }

    // Update is called once per frame
    void Update()
    {
        i+=1;
        if(i<200){
            this.gameObject.transform.Translate(moveSpeed*Time.deltaTime, 0,0);
        }
        print(this.gameObject.transform.position);
    }
}
