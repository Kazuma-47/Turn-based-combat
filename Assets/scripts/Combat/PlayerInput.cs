using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : AttackInput
{
    public CharacterStats Player;
    public CharacterStats Enemy;
    public void Attack()
    {
        useTackle(Enemy);
    }

    public void Heal()
    {
         Player.currentHP = useHeal(Player);
    }
}
