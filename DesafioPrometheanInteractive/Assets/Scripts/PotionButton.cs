using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PotionButton : MonoBehaviour
{
    public PotionIdentified potion;
    public GameObject Instances;
    public Image image;
    void Start()
    {
        image = this.GetComponent<Image>();
        potion = new PotionIdentified();
        potion = GetPotion();
        Debug.Log(potion.Name);
        image.sprite = potion.sprite;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public PotionIdentified GetPotion()
    {
        PotionIdentified newPotion = new PotionIdentified();
        newPotion = Instances.GetComponent<PotionInstance>().Potions[Random.Range(0, Instances.GetComponent<PotionInstance>().Potions.Count)];
        Instances.GetComponent<PotionInstance>().Potions.Remove(newPotion);
        return newPotion;
    }
}
