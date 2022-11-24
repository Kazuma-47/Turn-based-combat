using UnityEngine;

public class EnemyAI : AttackInput
{
    [HideInInspector] public bool attacking = true;
    public void Attack()
    {
        Move[] moves = GetComponent<TurnManager>().enemy.moves;
        int Ai = Random.Range(0, 9);
        print(attacking);
        if (attacking)
        {
            if (Ai >= 0 && Ai <= 3)
            {
                //move 1
                attacking = false;
                EnemyAttack(moves[0]);

            }
            else if (Ai >= 3 && Ai <= 6)
            {
                //move 2
                attacking = false;
                EnemyAttack(moves[1]);
            }
            else if (Ai >= 6 && Ai <= 9)
            {
                //move 3
                attacking = false;
                EnemyAttack(moves[2]);
            }
        }
    }
    
    public void EnemyAttack(Move _attack)
    {
        Players _player = GetComponent<TurnManager>().player;
        _player.TakeDamage(_attack.damage);
        var _playerPos = GameObject.FindWithTag("PlayerUnit").transform;
        onAttack.Invoke(_attack.VFX, _playerPos);
    }

    public void onTurnEnd()
    {
        attacking = true;
    }


}
