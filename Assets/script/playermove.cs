using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody move;
    public float moveslide = 15f;
    public GameObject powermode;
    public double powermodeTime = 2f;
    public double powermodeEndtime;

    public AudioSource MusicSorce; 
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       //move.AddForce(0,0,moveforward*Time.deltaTime);
       if(Input.GetKey("d")){
           move.AddForce(moveslide*Time.deltaTime,0,0,ForceMode.VelocityChange);
       }
       if(Input.GetKey("a")){
           move.AddForce(-moveslide*Time.deltaTime,0,0,ForceMode.VelocityChange);
       }
       if(move.position.y < -1f){
            FindObjectOfType <Game_Manager>().EndGame();
       }
        
       
        if (Input.GetKey("w") ){
           powermode.SetActive(true);
           PlayerPrefs.SetInt("powerMode",1); // 開啟噴射
           move.isKinematic = true;
           powermodeEndtime = Time.time + 3.0;
           MusicSorce.Play();
          
        }else if (Time.time > powermodeEndtime)
        {
            powermode.SetActive(false);
            move.isKinematic = false;
            PlayerPrefs.SetInt("powerMode", 0); // 關閉噴射
        }
    }
}
