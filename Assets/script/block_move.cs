using System.Collections;
using System.Collections.Generic;
using UnityEngine;


 // 控制障礙物的移動
public class block_move : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody move; //移動速度
    public Transform place; // ts
    private float moveforward = 800;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(place.position.z < -11){
          DestroyGameObject();
      }else{
           move.AddForce(0,0,-moveforward*Time.deltaTime);
      }
    }

     void DestroyGameObject()
    {
        Destroy(gameObject);
    }
}
