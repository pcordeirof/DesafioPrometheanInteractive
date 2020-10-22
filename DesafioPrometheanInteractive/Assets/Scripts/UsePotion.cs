using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UsePotion : MonoBehaviour, IPointerClickHandler
{
    public PotionsAvailable potionsAvailable;
    public PotionAllData potionInstance;
    public PotionButton potionButton;
    public GameObject PopUp;
    [SerializeField] private AudioClip useSfx;
    [SerializeField] private AudioSource sfxAudioSource;
 
    public void OnPointerClick(PointerEventData eventData)
    {
        if(potionInstance.potionStateBool == false)
        {
            PotionEffects newEffect = potionsAvailable.GetEffects();
            potionInstance.addEffect("Identificada", newEffect.potionNameTxt, newEffect.potionEffectName, newEffect.potionEffectDescription);
            
            potionButton.PotionEffect();
        }
        PopUp.SetActive(false);
        potionButton.ReduceQuantity();
        sfxAudioSource.PlayOneShot(useSfx);
    }

    public void getPotion(PotionAllData _potion, PotionButton _potionButton)
    {
        potionInstance = _potion;
        potionButton = _potionButton;
    }
}
