using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyAI : AttackInput
{
    public CharacterStats Player;
    public CharacterStats Enemy;


    public void Attack()
    {
        int Ai = Random.Range(0, 6);

        if (Ai >= 2)
        {
            useTackle(Enemy);
        }
        else
        {
            Player.currentHP = useHeal(Player);
        }

    }


}
