using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionsAvailable : MonoBehaviour
{
    public List<PotionAllData> Potions = new List<PotionAllData>();
    public List<PotionEffects> PossibleEffects = new List<PotionEffects>();

    public PotionAllData GetPotion()
    {
        PotionAllData newPotion = Potions[Random.Range(0, Potions.Count)];
        Potions.Remove(newPotion);
        return newPotion;
    }

    public PotionEffects GetEffects()
    {
        PotionEffects newEffect = PossibleEffects[Random.Range(0, PossibleEffects.Count)];
        PossibleEffects.Remove(newEffect);
        return newEffect;
    }
}
