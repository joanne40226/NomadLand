using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backToRoomFromMedia : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.transform.position = new Vector3(-5.78f ,-3.23f ,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown(){
        SceneManager.LoadScene(4); 
        
    }
}
