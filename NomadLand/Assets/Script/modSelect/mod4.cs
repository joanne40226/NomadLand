using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mod4 : MonoBehaviour
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
        if(i>440){
            this.gameObject.transform.position = new Vector3( 5.23f, -3.52f, 0);
        }
        
    }
    void OnMouseDown(){
        SceneManager.LoadScene(2); 
    }
}
