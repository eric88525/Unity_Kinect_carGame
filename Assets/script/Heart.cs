﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    public Transform[] spawnpoint;
    public GameObject heart;
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<spawnpoint.Length;i++){
            Instantiate(heart,spawnpoint[i].position,heart.transform.rotation);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}