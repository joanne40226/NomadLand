using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene : MonoBehaviour
{

    public void LoadStartScene(){
        SceneManager.LoadScene(1); //0 for starting Scene.
    }
    /*
    public void LoadAnnounceScene(){
        SceneManager.LoadScene(1); 
    }
    */
}
