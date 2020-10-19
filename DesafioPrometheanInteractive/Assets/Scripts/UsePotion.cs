using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UsePotion : MonoBehaviour, IPointerClickHandler
{
    public GameObject Instances;
    public GameObject Potion;
    void Start()
    {
    
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        PossiblePotion newPotion = new PossiblePotion();
        newPotion = Instances.GetComponent<PotionInstance>().PossiblePotions[Random.Range(0, Instances.GetComponent<PotionInstance>().PossiblePotions.Count)];
        Instances.GetComponent<PotionInstance>().PossiblePotions.Remove(newPotion);

        if(Potion.GetComponent<PotionButton>().potion.State != "Identificada")
        {
            Potion.GetComponent<PotionButton>().potion.addEffect("Identificada", newPotion.Name, newPotion.effectName, newPotion.effectDescription);
            Potion.GetComponent<PotionButton>().potion.quantity -= 1;

        }
    }
}
