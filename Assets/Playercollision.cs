using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercollision : MonoBehaviour
{
   //public PlayerMovement movement;
   public MonoBehaviour movement;

    void OnCollisionEnter(Collision CollisionInfo)
    {
        
        if(CollisionInfo.collider.tag == "Obstacle"){
            movement.enabled = false;
            FindObjectOfType <Game_Manager>().EndGame();
        }

    }












}
