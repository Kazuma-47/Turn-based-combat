using UnityEngine;
using UnityEngine.Events;

public class AttackInput : MonoBehaviour
{
    [SerializeField] private UnityEvent onTurnEnd = new UnityEvent();
    private Enemie enemy;
    private Players player;

    private void Start()
    {
        enemy = GetComponent<TurnManager>().enemy;
        player = GetComponent<TurnManager>().player;
    }

    public void atk1(int _move)
    {
        if (player.moves[_move] != null)        //check als het slot niks is  zo wel gebeurt niks
        {
            if (player.moves[_move].UsageLeft != 0)             //als de move nog gebruikt kan worden
            {
                enemy.currentHp -= player.moves[_move].damage;
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
        player.currentHp -= _attack.damage;
        onTurnEnd.Invoke();
    }

 
    
}
    