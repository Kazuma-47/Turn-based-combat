using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Enemie : BaseCharacter
{
    public int expGive;
    public int exp;
    public int grade;
    public void ExpWin()
    {
        expGive = (int)Mathf.Floor(Mathf.Pow(scale, level) * exp);
    }

}
