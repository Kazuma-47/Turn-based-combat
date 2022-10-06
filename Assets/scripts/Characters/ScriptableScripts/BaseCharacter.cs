using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BaseCharacter : ScriptableObject
{
    public string names;
    public Sprite artworks;
    public float health;
    public int maxHp;
    public int currentHp;
    public float scale = 1.024f;
    public int ad;
    public int currentAd;
    public float level;
    //public int Moves;
    public void Stats()
    {
        maxHp = (int)Mathf.Floor(Mathf.Pow(scale,level)*health);
        currentHp = maxHp;
        currentAd = (int)Mathf.Floor(Mathf.Pow(scale, level) * ad);
    }
}