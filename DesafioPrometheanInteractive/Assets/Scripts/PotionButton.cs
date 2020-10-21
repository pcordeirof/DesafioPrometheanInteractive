using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PotionButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public PotionAllData potionInstance;
    public PotionsAvailable potionAvailables;
    public GameObject potionDescription;
    public Text potionStateTxt;
    public Text potionNameTxt;
    public Text potionColorTxt;
    public Text potionEffectTxt;
    public Text potionQuantityTxt;
    public GameObject PopUpGameObject;
    public PopUpPotion PopUpClass;
    public Image potionImage;
    bool pointerOn = false;
    void Start()
    {   

        potionInstance = potionAvailables.GetPotion();
        
        potionImage.sprite = potionInstance.potionSprite;
        potionStateTxt.text = potionInstance.potionStateTxt;
        potionNameTxt.text = potionInstance.potionNameTxt;
        potionColorTxt.text += " " + potionInstance.potionColorTxt;
        potionQuantityTxt.text = potionInstance.potionQuantity.ToString();
        
        
    }
    public void PotionEffect()
    {
        potionStateTxt.text = potionInstance.potionStateTxt;
        potionNameTxt.text = potionInstance.potionNameTxt;
        potionEffectTxt.text += " " + potionInstance.potionEffectName;
        
        Debug.Log(potionInstance.potionEffectDescription);
    }

    public void ReduceQuantity()
    {
        potionInstance.potionQuantity --;
        if(potionInstance.potionQuantity > 0)
        {
            potionQuantityTxt.text = potionInstance.potionQuantity.ToString();
        }
        else 
        {
            Debug.Log(potionInstance.potionEffectDescription);
            this.gameObject.SetActive(false);
        }
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        pointerOn = !PopUpGameObject.activeSelf;
        potionDescription.SetActive(pointerOn);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        pointerOn = false;
        potionDescription.SetActive(pointerOn);
    }
    
    public void OnPointerClick(PointerEventData eventData)
    {
        PopUpClass.FillInfo(potionInstance, this);
        PopUpGameObject.SetActive(true);
        potionDescription.SetActive(false);
    }
}
