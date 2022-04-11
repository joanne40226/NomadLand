using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1 : MonoBehaviour
{
    public int player;
    // Start is called before the first frame update
    void Start()
    {
        
        this.gameObject.transform.position = new Vector3(11111f, 11111f,0 );
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.Find("background").GetComponent<chatRoom>().Player;
        if(player>=1){
            this.gameObject.transform.position = new Vector3(5.768f, 2.503f,0 );
        }
    }
}
