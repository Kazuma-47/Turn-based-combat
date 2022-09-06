using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class AttackInput : MonoBehaviour
{
    public Moves moves;
    [SerializeField] private  bool enemy;
    public CharacterStats Player;
    public CharacterStats Enemy;
    private CharacterStats targetToAttack;


    public void Target()
    {
        if (enemy)
        {
            targetToAttack = Player;
        }
        else
        {
            targetToAttack = Enemy;
        }
    }
    
        
    public void Attack(CharacterStats targetToAttack)
    {
        targetToAttack.currentHP = useTackle(targetToAttack);
    }
    public int useTackle(CharacterStats stats)
    {
        var newHP = moves.use(1, stats);
        return newHP;

    }
    public void useHeal(CharacterStats stats)
    {
        var newHP = moves.use(2, stats);
    }
    
}
