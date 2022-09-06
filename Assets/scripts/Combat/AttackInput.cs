using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class AttackInput : MonoBehaviour
{
    public Slider slider;
    public TurnManager TurnManager;
    public Moves moves;
    public int health;
    public int IntHP;
    public float FloatHP;

    private void Start()
    {
        health = CharacterStats.HP;
        FloatHP = Mathf.Pow(TurnManager.HpScale, CharacterStats.monsterLVL) * CharacterStats.monsterHP;
        IntHP = (int)Math.Round(FloatHP);
        slider.maxValue = 100;
        slider.value = IntHP;
        
    }

    public void useHeal()
    {
        
        slider.value = moves.use(2, TurnManager.IntHP, slider.maxValue);
        
    }
    
}
