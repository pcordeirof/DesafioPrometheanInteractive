using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PotionButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public PotionIdentified potion;
    public GameObject Instances;
    public GameObject description;
    public GameObject State;
    public GameObject Name;
    public GameObject Color;
    public GameObject Effect;
    public GameObject Quantity;
    public GameObject PopUp;
    public Image image;
    bool pointerOn = false;
    void Start()
    {
        image = this.GetComponent<Image>();
        potion = new PotionIdentified();
        
        description = this.gameObject.transform.GetChild(0).gameObject;
        State = this.gameObject.transform.GetChild(0).GetChild(0).gameObject;
        Name = this.gameObject.transform.GetChild(0).GetChild(1).gameObject;
        Color = this.gameObject.transform.GetChild(0).GetChild(2).gameObject;
        Effect = this.gameObject.transform.GetChild(0).GetChild(3).gameObject;
        Quantity = this.gameObject.transform.GetChild(2).gameObject;
        

        potion = GetPotion();
        
        image.sprite = potion.sprite;
        State.GetComponent<Text>().text = potion.State;
        Name.GetComponent<Text>().text = potion.Name;
        Color.GetComponent<Text>().text += " " + potion.color;
        Quantity.GetComponent<Text>().text = potion.quantity.ToString();
        
        PopUp = this.gameObject.transform.GetChild(1).gameObject;
        PopUp.transform.GetChild(1).gameObject.GetComponent<Image>().sprite = potion.sprite;
        PopUp.transform.GetChild(2).gameObject.GetComponent<Text>().text = potion.Name;
    }
    public PotionIdentified GetPotion()
    {
        PotionIdentified newPotion = new PotionIdentified();
        newPotion = Instances.GetComponent<PotionInstance>().Potions[Random.Range(0, Instances.GetComponent<PotionInstance>().Potions.Count)];
        Instances.GetComponent<PotionInstance>().Potions.Remove(newPotion);
        return newPotion;
    }

    public void PotionEffect()
    {
        State.GetComponent<Text>().text = potion.State;
        Name.GetComponent<Text>().text = potion.Name;
        Effect.GetComponent<Text>().text += " " + potion.effectName;
        PopUp.transform.GetChild(2).gameObject.GetComponent<Text>().text = potion.Name;
        Debug.Log(potion.effectDescription);
    }

    public void ReduceQuantity()
    {
        if(potion.quantity > 0)
        {
            Quantity.GetComponent<Text>().text = potion.quantity.ToString();
        }
        else 
        {
            Debug.Log(potion.effectDescription);
            this.gameObject.SetActive(false);
        }
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        pointerOn = PopUp.activeSelf == false ? true : false;
        description.SetActive(pointerOn);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        pointerOn = false;
        description.SetActive(pointerOn);
    }
    
    public void OnPointerClick(PointerEventData eventData)
    {
        PopUp.SetActive(true);
        description.SetActive(false);
    }
}
