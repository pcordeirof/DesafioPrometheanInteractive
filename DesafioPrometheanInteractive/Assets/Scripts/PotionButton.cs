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
    public GameObject Name;
    public GameObject PopUp;
    public Image image;
    bool pointerOn = false;
    void Start()
    {
        image = this.GetComponent<Image>();
        potion = new PotionIdentified();
        description = this.gameObject.transform.GetChild(0).gameObject;
        Name = this.gameObject.transform.GetChild(0).GetChild(0).gameObject;
        PopUp = this.gameObject.transform.GetChild(1).gameObject;
        potion = GetPotion();
        Debug.Log(potion.Name);
        image.sprite = potion.sprite;
        Name.GetComponent<Text>().text = potion.Name;
        
    }
    public PotionIdentified GetPotion()
    {
        PotionIdentified newPotion = new PotionIdentified();
        newPotion = Instances.GetComponent<PotionInstance>().Potions[Random.Range(0, Instances.GetComponent<PotionInstance>().Potions.Count)];
        Instances.GetComponent<PotionInstance>().Potions.Remove(newPotion);
        return newPotion;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        pointerOn = true;
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
    }
}
