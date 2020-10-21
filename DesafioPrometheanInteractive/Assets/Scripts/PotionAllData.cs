using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class PotionAllData
{
    public string potionNameTxt;
    public string potionColorTxt;
    public Sprite potionSprite;
    public int potionQuantity;
    public string potionStateTxt = "Não-identificada";
    public bool potionStateBool = false;
    public string potionEffectName;
    public string potionEffectDescription;

    public void addEffect(string _State, string _IdentifiedName, string _effectName, string _effectDescription)
    {
        potionStateTxt = _State;
        potionNameTxt = _IdentifiedName;
        potionEffectName = _effectName;
        potionEffectDescription = _effectDescription;
        potionStateBool = true;
    }

}
