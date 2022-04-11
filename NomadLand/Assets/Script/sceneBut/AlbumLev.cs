using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AlbumLev : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.transform.position = new Vector3 (-7.35f, 3.74f,0);   
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position = new Vector3 (-7.35f, 3.74f,0);   
    }
    void OnMouseDown(){
        SceneManager.LoadScene(5); 
    }
}
