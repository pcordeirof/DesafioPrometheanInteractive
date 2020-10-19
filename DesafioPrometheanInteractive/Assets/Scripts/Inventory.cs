using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject inventory;
    public bool state = false;
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
        }
    }
    
}
