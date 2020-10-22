using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private GameObject inventory;
    [SerializeField] private bool isActive = false;
    [SerializeField] private AudioClip openSfx;
    [SerializeField] private AudioSource sfxAudioSource;
    void Start()
    {
        inventory.SetActive(isActive);
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            isActive = !isActive;
            inventory.SetActive(isActive);
            sfxAudioSource.PlayOneShot(openSfx);
        }
    }
    
}
