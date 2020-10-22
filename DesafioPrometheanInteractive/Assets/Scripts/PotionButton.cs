using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PotionButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    [SerializeField] private PotionAllData potionInstance;
    [SerializeField] private PotionsAvailable availablePotions;
    [SerializeField] private GameObject potionDescription;
    [SerializeField] private Text potionStateTxt;
    [SerializeField] private Text potionNameTxt;
    [SerializeField] private Text potionColorTxt;
    [SerializeField] private Text potionEffectName;
    [SerializeField] private Text potionQuantityTxt;
    [SerializeField] private PopUpPotion PopUpPotion;
    [SerializeField] private Image potionImage;
    [SerializeField] private AudioClip hoverSfx;
    [SerializeField] private AudioClip clickSfx;
    [SerializeField] private AudioSource sfxAudioSource;
    
    void Start()
    {   

        potionInstance = availablePotions.GetPotion();
        
        potionImage.sprite = potionInstance.potionSprite;
        potionStateTxt.text = potionInstance.potionState;
        potionNameTxt.text = potionInstance.potionName;
        potionColorTxt.text += " " + potionInstance.potionColor;
        potionQuantityTxt.text = potionInstance.potionQuantity.ToString();
        
        
    }
    public void AttributePotionEffect()
    {
        potionStateTxt.text = potionInstance.potionState;
        potionNameTxt.text = potionInstance.potionName;
        potionEffectName.text += " " + potionInstance.potionEffectName;
        
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
        if(PopUpPotion.popUp.activeSelf == false)
        {
            potionDescription.SetActive(true);
            sfxAudioSource.PlayOneShot(hoverSfx);
        }
        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        potionDescription.SetActive(false);
    }
    
    public void OnPointerClick(PointerEventData eventData)
    {
        PopUpPotion.OnDisplay(potionInstance, this);
        potionDescription.SetActive(false);
        sfxAudioSource.PlayOneShot(clickSfx);
    }
}
