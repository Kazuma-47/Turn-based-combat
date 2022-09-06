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


    private void Start()
    {
        print(TurnManager.FloatHP);
        print(TurnManager.IntHP);
        
    }

    public void useHeal()
    {
        slider.value = TurnManager.IntHP;
        slider.maxValue = TurnManager.FloatHP;
        slider.value = moves.use(2, TurnManager.IntHP, TurnManager.FloatHP);
        
    }
    
}
