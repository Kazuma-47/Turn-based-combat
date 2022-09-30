using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Enemie : BaseCharacter
{
    public int EXPGive;
    public int EXP;
    public int grade;
    public void Level(int min, int max)
    {
        Levelen = Random.Range(min, max);
    }
    public void EXPWin()
    {
        EXPGive = (int)Mathf.Floor(Mathf.Pow(Factor, Levelen) * EXP);
    }

}
