using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class PotionAllData
{
    public string potionName;
    public string potionColor;
    public Sprite potionSprite;
    public int potionQuantity;
    public string potionState = "Não-identificada";
    public bool isIdentified = false;
    public string potionEffectName;
    public string potionEffectDescription;

    public void AddEffect(string _potionState, string _identifiedName, string _potionEffectName, string _potionEffectDescription)
    {
        potionState = _potionState;
        potionName = _identifiedName;
        potionEffectName = _potionEffectName;
        potionEffectDescription = _potionEffectDescription;
        isIdentified = true;
    }

}
