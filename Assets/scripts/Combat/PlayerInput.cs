using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : AttackInput
{
    
    public void Attack()
    {
        Enemy.currentHP = useTackle(Enemy);
    }

    public void Heal()
    {
         Player.currentHP = useHeal(Player);
    }
}
