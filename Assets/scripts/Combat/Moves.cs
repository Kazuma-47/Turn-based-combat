using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moves : MonoBehaviour
{
    public int use(int MoveID , int TargetHP, int MaxHP)
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

    public int Heal(int currentHealth , int maxHealth)
    {
       int amount = maxHealth / 100 * 20;   //voor een reden geeft amount 0 terug hij krijgt wel maxhealth goed mee _____formule fout??
       print(amount);
       return currentHealth;
    }
}
