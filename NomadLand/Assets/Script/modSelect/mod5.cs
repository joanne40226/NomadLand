using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mod5 : MonoBehaviour
{
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        if(i>470){
            this.gameObject.transform.position = new Vector3( 6.93f, -3.5f, 0);    
        }
    }
    void OnMouseDown(){
        SceneManager.LoadScene(2); 
    }
}
