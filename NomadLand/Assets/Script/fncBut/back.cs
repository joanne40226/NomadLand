using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class back : MonoBehaviour
{    
    int i = 0;
    void Update()
    {
        i++;
        if(i>470){
            this.gameObject.transform.position = new Vector3( -7f, -4f, 0);
        }
    }
    void OnMouseDown(){
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex-1); 
    }
}
