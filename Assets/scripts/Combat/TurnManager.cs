using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;


public class TurnManager : MonoBehaviour
{
    private State _state;
    [SerializeField] private UnityEvent onEnemyTurn = new UnityEvent();
    [SerializeField] private UnityEvent onTurnEnd = new UnityEvent();
    [SerializeField] private UIManager ui;
    public Players player;
    public Enemie enemy;

    private enum State
    {
        PlayerTurn,
        EnemyTurn
        
    }
    
    private void Update()
    {
        
        if (_state == State.PlayerTurn)
        {
            ui.SetCharacterUI(player);
        }
        else if (_state == State.EnemyTurn)
        {
            
            ui.ChangeUIMenu();
            onEnemyTurn.Invoke();
            
        }
    }

    public void ChangeState()
    {
        if (_state == State.PlayerTurn)
        {
            _state = State.EnemyTurn;
            CheckWin();
            onTurnEnd.Invoke();
        }
        else if (_state == State.EnemyTurn)
        {
            _state = State.PlayerTurn;
            CheckWin();
            onTurnEnd.Invoke();
        }
    }
    public void CheckWin()
    {
       if(enemy.CurrentHP <= 0f)
       {
           SceneManager.LoadScene("win");
       }

       if (player.CurrentHP <= 0f)
       {
           SceneManager.LoadScene("lose");
       }
    }
}