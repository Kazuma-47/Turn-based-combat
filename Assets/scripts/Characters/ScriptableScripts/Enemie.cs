using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Enemie : BaseCharacter
{
    [SerializeField] private int baseExp;
    private int expGive;
    public int grade;
    public void Level(int _min, int _max)
    {
        level = Random.Range(_min, _max);
    }
    public int EXPWin()
    {
        return expGive = (int)Mathf.Floor(Mathf.Pow(factor, level) * baseExp);
    }

}
