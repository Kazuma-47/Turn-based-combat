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
        Enemie target = GetComponent<TurnManager>().enemie;
        Enemie player = GetComponent<TurnManager>().player;
        if (player.moves[move] != null)
        {
            if (player.moves[move].UsageLeft != 0)
            {
                target.Health -= player.moves[move].damage;
                print("player attacked and used " + player.moves[move].name);
                player.moves[move].UsageLeft -= 1;
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
        Enemie target = GetComponent<TurnManager>().player;
        target.Health -= attack.damage;
        print("enemy attacked and used " + attack.name);
        onTurnEnd.Invoke();
    }

    public void guard()
    {
        Enemie player = GetComponent<TurnManager>().player;

    }
    
}
    