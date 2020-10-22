using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpPotion : MonoBehaviour
{
    public GameObject popUp;
    [SerializeField] private Image popUpImage;
    [SerializeField] private Text popUpTxt;
    [SerializeField] private UsePotion usePotion;

    public void OnDisplay(PotionAllData _potionInstance, PotionButton _potionButton)
    {
        popUpImage.sprite = _potionInstance.potionSprite;
        popUpTxt.text = _potionInstance.potionName;
        usePotion.GetPotion(_potionInstance, _potionButton);
        popUp.SetActive(true);
    }
}
