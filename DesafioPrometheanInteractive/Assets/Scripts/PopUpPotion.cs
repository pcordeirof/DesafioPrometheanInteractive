using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpPotion : MonoBehaviour
{
    public Image popUpImage;
    public Text popUpTxt;
    public UsePotion usePotion;

    public void FillInfo(PotionAllData _potionInstance, PotionButton _potionButton)
    {
        popUpImage.sprite = _potionInstance.potionSprite;
        popUpTxt.text = _potionInstance.potionNameTxt;
        usePotion.getPotion(_potionInstance, _potionButton);
    }
}
