using UnityEngine;
using UnityEngine.Events;

public class AttackInput : MonoBehaviour
{
    [SerializeField] protected UnityEvent<ParticleSystem,Transform> onAttack = new UnityEvent<ParticleSystem,Transform>();
    
    public void atk1(int _move)
    {
        var player = GetComponent<TurnManager>().player;
        var enemy = GetComponent<TurnManager>().enemy;
        var EnemyPos = GameObject.FindWithTag("EnemyUnit");
        if (player.moves[_move] != null)        //check als het slot niks is  zo wel gebeurt niks
        {
            if (player.moves[_move].usageLeft != 0)             //als de move nog gebruikt kan worden
            {
                enemy.TakeDamage(player.moves[_move].damage);
                player.moves[_move].usageLeft -= 1;
               
                onAttack.Invoke(player.moves[_move].VFX, EnemyPos.transform);
            }
            else
            {
                print("no more usage");
            }
        }
    }

    

 
    
}
    