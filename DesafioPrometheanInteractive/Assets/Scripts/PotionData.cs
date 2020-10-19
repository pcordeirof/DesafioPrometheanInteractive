using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class PotionData
{
    public string Name;
    public string color;
    public Sprite sprite;
    
}
[Serializable]
public class PotionIdentified : PotionData
{
    public string effectName;
    public string effectDescription;

    public void addEffect(string _IdentifiedName, string _effectName, string _effectDescription)
    {
        Name = _IdentifiedName;
        effectName = _effectName;
        effectDescription = _effectDescription;
    }

}
[Serializable]
public struct PossiblePotion
{
    public string Name;
    public string effectName;
    public string effectDescription;
}

