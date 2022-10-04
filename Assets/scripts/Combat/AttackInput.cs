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
    private GameObject _currentTarget;
    [SerializeField] private UnityEvent onTurnEnd = new UnityEvent();

    public void atk1(int move)
    {
        Enemie target = GetComponent<TurnManager>().enemy;
        Players player = GetComponent<TurnManager>().player;
        if (player.Moves[move] != null)
        {
            if (player.Moves[move].UsageLeft != 0)
            {
                target.CurrentHP -= player.Moves[move].damage;
                print("player attacked and used " + player.Moves[move].name);
                player.Moves[move].UsageLeft -= 1;
                
                onTurnEnd.Invoke();
            }
            else
            {
                print("no more usage");
            }
        }
    }

    public void enemyattack(Move attack)
    {
        Players target = GetComponent<TurnManager>().player;
        target.CurrentHP -= attack.damage;
        print("enemy attacked and used " + attack.name);
        onTurnEnd.Invoke();
    }

 
    
}
    