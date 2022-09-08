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
    [SerializeField] private  bool enemy;
    public CharacterStats Player;
    public CharacterStats Enemy;
    private CharacterStats _targetToAttack;
    [SerializeField] private UnityEvent Event = new UnityEvent();

    private void Start()
    {
        Target();
    }

    public void Target()
    {
        if (enemy)
        {
            _targetToAttack = Player;
        }
        else
        {
            _targetToAttack = Enemy;
        }
    }


    public void Attack()
    {
        _targetToAttack.currentHP = useTackle(_targetToAttack);
    }

    public void Heal()
    {
        {
            if(enemy == false)
                Player.currentHP = useHeal(Player);
            else if (enemy) 
                Enemy.currentHP = useHeal(Enemy);
        }
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
        Event.Invoke();
        return newHP;
    }
    
}
