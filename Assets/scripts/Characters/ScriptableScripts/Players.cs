using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Players : BaseCharacter
{
    public int exp;
    public int baseExp;
    public int expCap;
    
    public void ExpGet(int expGive)
    {
        exp = exp + expGive;
        if (exp >= expCap)
        {
            LevelUp();
        }
        Debug.Log(exp);
    }

    public void LevelUp()
    {
        exp = exp - expCap; 
        level = level + 1;
        expCap = (int)Mathf.Floor(Mathf.Pow(scale, level) * baseExp);
        Stats();
    }
    public void StartUp() 
    {
        level = 5;
        expCap = (int)Mathf.Floor(Mathf.Pow(scale, level) * baseExp);
        Stats();
    }
}
