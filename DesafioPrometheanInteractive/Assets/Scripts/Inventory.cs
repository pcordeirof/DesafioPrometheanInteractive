﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private GameObject inventory;
    [SerializeField] private bool state = false;
    [SerializeField] private AudioClip openSfx;
    [SerializeField] private AudioSource sfxAudioSource;
    void Start()
    {
        inventory.SetActive(state);
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            state = !state;
            inventory.SetActive(state);
            sfxAudioSource.PlayOneShot(openSfx);
        }
    }
    
}
