﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test15 : MonoBehaviour
{
    private AudioSource theAudio;

    [SerializeField] private AudioClip[] clip;
    // Start is called before the first frame update
    void Start()
    {
        theAudio = GetComponent<AudioSource>();
    }
    public void PlaySE()
    {
        int _temp = Random.Range(0, 4);
        theAudio.clip = clip[_temp];
        theAudio.Play();

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
