using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Players : BaseCharacter
{
    #region Variables
    [SerializeField] private int baseExp;
    private int exp, expCap;
    #endregion

    #region Functions
    public void ExpGet(int _expGive)
    {
        exp = exp + _expGive;
        if (exp >= expCap)
        {
            LevelUp();
        }
    }

    public void LevelUp()
    {
        exp = exp - expCap; 
        level = level + 1;
        expCap = (int)Mathf.Floor(Mathf.Pow(factor, level) * baseExp);
        Stats();
    }
    public void StartUp() 
    {
        level = 5;
        expCap = (int)Mathf.Floor(Mathf.Pow(factor, level) * baseExp);
        Stats();
        SetMoveUsage();
    }
    #endregion
}
