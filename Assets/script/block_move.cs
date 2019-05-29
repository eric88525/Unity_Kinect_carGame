using System.Collections;
using System.Collections.Generic;
using UnityEngine;


 // 控制障礙物的移動
public class block_move : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody move; //移動速度
    public Transform place; // ts

    private float moveforward ;
    void Start()
    {
        moveforward = Getspeed();
    }

    // Update is called once per frame
    void Update()
    {
       if(PlayerPrefs.GetInt("powerMode")==1){
           move.AddForce(0,0,-1500*Time.deltaTime,ForceMode.VelocityChange);
      }else if(place.position.z < -11){
          DestroyGameObject();
      }else{
           move.AddForce(0,0,-moveforward*Time.deltaTime);
      }
    }
    void OnCollisionEnter(Collision CollisionInfo)
    {
        
        if(CollisionInfo.collider.tag == "Player"){
            if( PlayerPrefs.GetInt("powerMode")==1){
                move.AddForce(0,-5,500*Time.deltaTime,ForceMode.VelocityChange);
            }
        }

    }
     void DestroyGameObject()
    {
        Destroy(gameObject);
    }
    float Getspeed(){
        float speed = PlayerPrefs.GetFloat("Obs_speed");;
        return speed;
    }
}
