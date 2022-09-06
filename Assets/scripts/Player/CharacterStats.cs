using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public CreatePlayer createPlayer;
    public int baseHP;
    public float MaxHP;
    public static int savedcurrentHP;
    public int currentHP;
    public static int LVL;
    public static int monsterHP = 30;


    public int[] moves;

    private void Start()
    {
       
        LVL = createPlayer.lvl;
        baseHP = createPlayer.baseHp;
        moves = createPlayer.MoveIds;
        MaxHP =Mathf.Pow(createPlayer.HpScale, LVL) * baseHP;
        MaxHP = Mathf.Round(MaxHP);
    }

    public void GetHP(int lastHp)
    {
        savedcurrentHP = lastHp;
    }

    public void levelup()
    {
        LVL = LVL + 1;
    }
    public void SetHp()
    {
        currentHP = savedcurrentHP;
    }


}
