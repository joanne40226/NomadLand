using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backGeneral : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.transform.position = new Vector3( -7f, -4f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position = new Vector3( -7f, -4f, 0);        
    }
    void OnMouseDown(){
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex-1); 
    }
}
