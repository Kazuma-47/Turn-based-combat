using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moves : MonoBehaviour
{
    public int use( int moveID, CharacterStats stats)
    {
        if (moveID == 1) {return Tackle(stats.currentHP);}
        if (moveID == 2){ return Heal(stats.currentHP, stats.MaxHP);}
        else return stats.currentHP;
    }

    public int Tackle(int TargetHP)
    {
        int dmg = 10;
        TargetHP = TargetHP - dmg;
        return TargetHP;

    }

    public int Heal(int currentHealth , float maxHealth)
    {
       int amount = (int)Mathf.Round(maxHealth / 100f * 20f);
        return currentHealth + amount;
    }
}
