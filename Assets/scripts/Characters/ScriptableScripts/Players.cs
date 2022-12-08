using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Players : BaseCharacter
{
    #region Variables
    [SerializeField] private int baseExp;
    [SerializeField] private int exp, expCap;
    #endregion

    #region Functions
    public void ExpGet(int _expGive)
    {
        exp = exp + _expGive;
        if (exp >= expCap)
        {
            LevelUp();
        }
        Debug.Log(exp);
        Debug.Log(level);
    }

    public void LevelUp()
    {
        exp = exp - expCap; 
        level += 1;
        expCap = (int)Mathf.Floor(Mathf.Pow(factor, level) * baseExp);
        Stats();
        if (exp >= expCap)
        {
            LevelUp();
        }

    }
    public void StartUp() 
    {
        level = 5;
        exp = 0;
        expCap = (int)Mathf.Floor(Mathf.Pow(factor, level) * baseExp);
        Stats();
    }
    #endregion
}
