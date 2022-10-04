using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Players : BaseCharacter
{
    public int EXP;
    public int Stonks;
    public int EXPCap;

    public void EXPGet(int EXPGive)
    {
        EXP = EXP + EXPGive;
        if (EXP >= EXPCap)
        {
            LevelUp();
        }
        Debug.Log(EXP);
    }

    public void LevelUp()
    {
        EXP = EXP - EXPCap; 
        Levelen = Levelen + 1;
        EXPCap = (int)Mathf.Floor(Mathf.Pow(Factor, Levelen) * Stonks);
        Stats();
    }
    public void startUp() 
    {
        Levelen = 5;
        EXPCap = (int)Mathf.Floor(Mathf.Pow(Factor, Levelen) * Stonks);
        Stats();
    }
}
