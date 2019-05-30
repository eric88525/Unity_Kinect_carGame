using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
public class StartGame : MonoBehaviour
{
    public Transform mouseLocation;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetMouseButtonDown(0)){
            SceneManager.LoadScene("LV1");
           
            Debug.Log("Pressed primary button.");
         }
    }
}
