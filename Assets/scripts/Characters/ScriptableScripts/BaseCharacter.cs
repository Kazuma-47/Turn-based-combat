using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BaseCharacter : ScriptableObject
{
    [SerializeField] private string characterName;
    [SerializeField] protected float factor = 1.024f;
    [SerializeField] private int ad;
    [SerializeField] private float baseHealth;
    public Sprite sprite;
    public Move[] moves = new Move[3];
    public int maxHp;
    public int currentHp;
    public int currentAd;
    public float level;

    public void Stats()
    {
        maxHp = (int)Mathf.Floor(Mathf.Pow(factor,level)*baseHealth);
        currentHp = maxHp;
        currentAd = (int)Mathf.Floor(Mathf.Pow(factor, level) * ad);
    }
}