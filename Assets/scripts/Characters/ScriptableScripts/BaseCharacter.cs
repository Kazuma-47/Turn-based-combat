using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BaseCharacter : ScriptableObject
{
<<<<<<< Updated upstream
    [SerializeField] protected float factor = 1.024f;
=======
    #region Variables
    [SerializeField] protected float factor;
>>>>>>> Stashed changes
    [SerializeField] private string characterName;
    [SerializeField] private int ad;
    [SerializeField] private float baseHealth;

    public Sprite sprite;
    public Move[] moves = new Move[3];
<<<<<<< Updated upstream
    public int maxHp, currentHp;
    public int currentAttackDamage;
    public float level;
=======
    [HideInInspector] public int maxHp, currentHp;
    [HideInInspector] public int currentAttackDamage;
    [HideInInspector] public float level;
    #endregion
>>>>>>> Stashed changes

    public void Stats()
    {
        maxHp = (int)Mathf.Floor(Mathf.Pow(factor,level)*baseHealth);
        currentHp = maxHp;
        currentAttackDamage = (int)Mathf.Floor(Mathf.Pow(factor, level) * ad);
    }
}