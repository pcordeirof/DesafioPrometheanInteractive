using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PotionButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    [SerializeField] private PotionAllData potionInstance;
    [SerializeField] private PotionsAvailable potionAvailables;
    [SerializeField] private GameObject potionDescription;
    [SerializeField] private Text potionStateTxt;
    [SerializeField] private Text potionNameTxt;
    [SerializeField] private Text potionColorTxt;
    [SerializeField] private Text potionEffectTxt;
    [SerializeField] private Text potionQuantityTxt;
    [SerializeField] private GameObject PopUpGameObject;
    [SerializeField] private PopUpPotion PopUpClass;
    [SerializeField] private Image potionImage;
    bool pointerOn = false;
    [SerializeField] private AudioClip hoverSfx;
    [SerializeField] private AudioClip clickSfx;
    [SerializeField] private AudioSource sfxAudioSource;
    
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
        if(PopUpGameObject.activeSelf != true)
        {
            pointerOn = true;
            potionDescription.SetActive(pointerOn);
            sfxAudioSource.PlayOneShot(hoverSfx);
        }
        
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
        sfxAudioSource.PlayOneShot(clickSfx);
    }
}
