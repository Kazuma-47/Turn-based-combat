using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BaseCharacter : ScriptableObject
{
    public string Name;
    public Sprite Artworks;
    public float Health;
    public int MaxHP;
    public int CurrentHP;
    public float Factor = 1.024f;
    public int AD;
    public int CurrentAD;
    public float Levelen;
    public Move[] Moves = new Move[3];
    public void Stats()
    {
        MaxHP = (int)Mathf.Floor(Mathf.Pow(Factor,Levelen)*Health);
        CurrentHP = MaxHP;
        CurrentAD = (int)Mathf.Floor(Mathf.Pow(Factor, Levelen) * AD);
    }
}