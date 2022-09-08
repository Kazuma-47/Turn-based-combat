using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class AttackInput : MonoBehaviour
{

    public Moves moves;
    [SerializeField] private UnityEvent Event = new UnityEvent();


    public int useTackle(CharacterStats stats)
    {
        var newHP = moves.Tackle(stats.currentHP);
        Event.Invoke();
        return newHP;

    }
    public int useHeal(CharacterStats stats)
    {
        var newHP = moves.Heal(stats.currentHP, stats.MaxHP);
        Event.Invoke();
        return newHP;
    }
    
}
