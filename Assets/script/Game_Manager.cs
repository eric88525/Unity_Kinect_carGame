using UnityEngine;
using UnityEngine.SceneManagement;
public class Game_Manager : MonoBehaviour
{

    bool gameEnd = false;
    public float restartDelay = 1f;

    private int freshTime = 10;
    public void EndGame(){
        if(gameEnd == false){
            gameEnd = true;
        }
        Debug.Log("over");
        int Hp = PlayerPrefs.GetInt("Hp");
        if(Hp>0){
            Invoke("Restart",restartDelay);
        }else{
            GameOver();
        }
    }
    void Restart(){
        int Hp = PlayerPrefs.GetInt("Hp");
        Hp-=1;
        PlayerPrefs.SetInt("Hp", Hp);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    void GameOver(){
        SceneManager.LoadScene("Menu");
    }
     void Update()
    {
        int time = (int)Time.time;
        float speed = PlayerPrefs.GetFloat("Obs_speed");
        if(Time.time> freshTime){
            PlayerPrefs.SetFloat("Obs_speed",speed+100);
            freshTime = time + 5;
        }   
    }

    void Start()
    {
        PlayerPrefs.SetFloat("Obs_speed",500);
         PlayerPrefs.SetInt("powerMode", 0); 
    }
}
