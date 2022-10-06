using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Enemie : BaseCharacter
{
    [SerializeField] private int baseExp;
    private int expGive;
    public int grade;
    public void Level(int min, int max)
    {
        level = Random.Range(min, max);
    }
    public int EXPWin()
    {
        expGive = (int)Mathf.Floor(Mathf.Pow(factor, level) * baseExp);
        return expGive;
    }

}
