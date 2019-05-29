using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Preference : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Hp", 3);        //playr hp
        PlayerPrefs.SetFloat("Obs_speed",500); //障礙物移動速度
        PlayerPrefs.SetInt("powerMode", 0); // 0 off 1 on   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
