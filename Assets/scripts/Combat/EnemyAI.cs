using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class EnemyAI : AttackInput
{
    
    public void Attack()
    {
        Move[] moves = GetComponent<TurnManager>().enemy.Moves;
        int Ai = Random.Range(0, 9);
        

        if (Ai >=0 && Ai <= 3 )
        {
            //move 1
            enemyattack(moves[0]);
            
        }
        else if(Ai >= 3 && Ai <= 6)
        {   
            //move 2
            enemyattack(moves[1]);
        }
        else if (Ai >= 6 && Ai <= 9)
        {
            //move 3
            enemyattack(moves[2]);
        }

    }


}
