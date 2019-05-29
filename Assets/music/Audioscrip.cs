using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audioscrip : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip MusicClip;
    public AudioSource MusicSorce; 
    void Start()
    {
        MusicSorce.clip = MusicClip;
        MusicSorce.Play();
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
