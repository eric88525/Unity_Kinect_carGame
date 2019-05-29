using UnityEngine;
public class PlayerCollision : MonoBehaviour
{
   //public PlayerMovement movement;
   public MonoBehaviour movement;
   public Rigidbody rb; 
    void OnCollisionEnter(Collision CollisionInfo)
    {
        
        if(CollisionInfo.collider.tag == "Obstacle" && PlayerPrefs.GetInt("powerMode")==0){
            Debug.Log("over");
            movement.enabled = false;
            FindObjectOfType <Game_Manager>().EndGame();
        }

    }












}
