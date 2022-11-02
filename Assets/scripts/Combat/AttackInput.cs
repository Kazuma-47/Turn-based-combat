using UnityEngine;
using UnityEngine.Events;

public class AttackInput : MonoBehaviour
{
    [SerializeField] private UnityEvent onTurnEnd = new UnityEvent();




    public void atk1(int _move)
    {
        var player = GetComponent<TurnManager>().player;
        var enemy = GetComponent<TurnManager>().enemy;
        if (player.moves[_move] != null)        //check als het slot niks is  zo wel gebeurt niks
        {
            if (player.moves[_move].UsageLeft != 0)             //als de move nog gebruikt kan worden
            {
                enemy.TakeDamage(player.moves[_move].damage);
                player.moves[_move].UsageLeft -= 1;
                onTurnEnd.Invoke();
            }
            else
            {
                print("no more usage");
            }
        }
    }

    public void EnemyAttack(Move _attack)
    {
        var player = GetComponent<TurnManager>().player;
        player.currentHp -= _attack.damage;
        onTurnEnd.Invoke();
    }

 
    
}
    