using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;


public class TurnManager : MonoBehaviour
{
    private State state;
    [SerializeField] private UnityEvent onEnemyTurn = new UnityEvent();
    [SerializeField] private UnityEvent onTurnEnd = new UnityEvent();
    [SerializeField] private UIManager ui;
    public Players player;
    public Enemie enemy;

    private enum State              //explains in which fase we are in combat
    {
        PlayerTurn,
        EnemyTurn
        
    }
    
    private void Update()
    {
        
        if (state == State.PlayerTurn)
        {
            ui.SetCharacterUI(player);
        }
        else if (state == State.EnemyTurn)
        {
            
            ui.ChangeUIMenu();
            onEnemyTurn.Invoke();
            
        }
    }

    public void ChangeState()   //switches the state to show who's turn it is
    {
        if (state == State.PlayerTurn)
        {
            state = State.EnemyTurn;
            CheckWin();
            onTurnEnd.Invoke();
        }
        else if (state == State.EnemyTurn)
        {
            state = State.PlayerTurn;
            CheckWin();
            onTurnEnd.Invoke();
        }
    }
    public void CheckWin()
    {
       if(enemy.currentHp <= 0f)
       {
           SceneManager.LoadScene("win");
       }

       if (player.currentHp <= 0f)
       {
           SceneManager.LoadScene("lose");
       }
    }
}