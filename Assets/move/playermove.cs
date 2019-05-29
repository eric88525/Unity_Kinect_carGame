using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody move;
    public float moveslide = 15f;
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
        if(Input.GetKey("w")){
           move.AddForce(0,moveslide*Time.deltaTime,0);
       }
    }
}
