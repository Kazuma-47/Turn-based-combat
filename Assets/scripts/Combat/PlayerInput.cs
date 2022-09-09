using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : AttackInput
{
    
    public void Attack()
    {
        Enemy.currentHP = useTackle(Enemy);
        //update healhbar enemy

        if (Enemy.currentHP <= 0)
        {
            //sethp en win screen
        }
    }

    public void Heal()
    {
         Player.currentHP = useHeal(Player);
        //update healhbar player
    }
}
