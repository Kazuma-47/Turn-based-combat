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
            updateHp.Invoke(Player.currentHP, Enemy.currentHP);


            if (Player.currentHP <= 0) 
            {
            SceneManager.LoadScene(sceneBuildIndex:2);
            }
        }
        else
        {
            print("healed");
            Enemy.currentHP = useHeal(Enemy);
            updateHp.Invoke(Player.currentHP, Enemy.currentHP);
            
        }

    }


}
