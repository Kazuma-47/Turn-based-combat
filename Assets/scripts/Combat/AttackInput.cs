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
    public CharacterStats Player;
    public CharacterStats Enemy;
    public Moves moves;
    [SerializeField] private UnityEvent Event = new UnityEvent();
    [SerializeField] protected UnityEvent<int,int> updateHp = new UnityEvent<int,int>();
    [SerializeField] private UnityEvent<CharacterStats,CharacterStats> start = new UnityEvent<CharacterStats,CharacterStats>();

    private void Start()
    {
        updateHp.Invoke(Player.currentHP, Enemy.currentHP);
        start.Invoke(Player, Enemy);
       
    }

    public int useTackle(CharacterStats stats)
    {
        var newHP = moves.Tackle(stats.currentHP);
        Event.Invoke();
        return newHP;

    }
    public int useHeal(CharacterStats stats)
    {
        
        var newHP = moves.Heal(stats.currentHP, stats.MaxHP);
        if (newHP > stats.MaxHP)
        {
            newHP = (int)Mathf.Round(stats.MaxHP);
        }
        Event.Invoke();
        return newHP;
    }
    
}
