
using UnityEngine;

public class box_spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform[] spawnpoint;
    public GameObject[] blocks;

    private int spawnNums = 1; //生成數量
    private float timespawn = 3f; // 生成時間點
    private float timewaves = 3f; // 間隔
    private Quaternion rotation = Quaternion.Euler (0, -180, 0);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= timespawn){
             Spawablocks();
             timespawn = Time.time + timewaves;
        }      
    }
    void Spawablocks(){
        int randomIndex = Random.Range(0,spawnpoint.Length);

        for(int i=0;i<spawnpoint.Length;i++){
            if(randomIndex != i){
                int randomType = Random.Range(0,spawnpoint.Length);
                Instantiate(blocks[randomType],spawnpoint[i].position,rotation);
            }
        }
    }
}
