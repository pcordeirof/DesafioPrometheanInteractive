using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UsePotion : MonoBehaviour, IPointerClickHandler
{
    public GameObject Instances;
    public GameObject Potion;
    public GameObject PopUp;
 
    public void OnPointerClick(PointerEventData eventData)
    {

        if(Potion.GetComponent<PotionButton>().potion.State != "Identificada")
        {
            PossiblePotion newPotion = Instances.GetComponent<PotionInstance>().PossiblePotions[Random.Range(0, Instances.GetComponent<PotionInstance>().PossiblePotions.Count)];
            Instances.GetComponent<PotionInstance>().PossiblePotions.Remove(newPotion);
            Potion.GetComponent<PotionButton>().potion.addEffect("Identificada", newPotion.Name, newPotion.effectName, newPotion.effectDescription);
            
            Potion.GetComponent<PotionButton>().PotionEffect();

        }
        PopUp.SetActive(false);
        Potion.GetComponent<PotionButton>().potion.quantity --;
        Potion.GetComponent<PotionButton>().ReduceQuantity();
    }
}
