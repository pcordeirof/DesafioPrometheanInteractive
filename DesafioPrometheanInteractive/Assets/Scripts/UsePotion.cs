using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UsePotion : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private PotionsAvailable potionsAvailable;
    [SerializeField] private PotionAllData potionInstance;
    [SerializeField] private PotionButton potionButton;
    [SerializeField] private GameObject PopUp;
    [SerializeField] private AudioClip useSfx;
    [SerializeField] private AudioSource sfxAudioSource;
 
    public void OnPointerClick(PointerEventData eventData)
    {
        if(potionInstance.isIdentified == false)
        {
            PotionEffects newEffect = potionsAvailable.GetEffects();
            potionInstance.AddEffect("Identificada", newEffect.potionNameTxt, newEffect.potionEffectName, newEffect.potionEffectDescription);
            
            potionButton.AttributePotionEffect();
        }
        PopUp.SetActive(false);
        potionButton.ReduceQuantity();
        sfxAudioSource.PlayOneShot(useSfx);
    }

    public void GetPotion(PotionAllData _potion, PotionButton _potionButton)
    {
        potionInstance = _potion;
        potionButton = _potionButton;
    }
}
