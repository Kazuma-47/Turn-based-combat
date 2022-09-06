using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moves : MonoBehaviour
{
    public int use(int MoveID , int TargetHP, float MaxHP)
    {
        if (MoveID == 1) return Tackle(TargetHP);
        else if (MoveID == 2) return Heal(TargetHP, MaxHP);
        else return TargetHP;
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
