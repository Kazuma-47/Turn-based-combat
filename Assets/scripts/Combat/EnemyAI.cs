using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class EnemyAI : AttackInput
{
    public void Attack()
    {
        int Ai = Random.Range(0, 6);
        

        if (Ai >= 1)
        {
            print("attacked");
            Player.currentHP = useTackle(Player);
            //update healhbar player


            if (Player.currentHP <= 0) 
            {
            SceneManager.LoadScene(sceneBuildIndex:2);
            }
        }
        else
        {
            print("healed");
            Enemy.currentHP = useHeal(Enemy);

            //update healhbar enemy
        }

    }


}
