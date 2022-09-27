using System;
using UnityEngine;
using UnityEngine.Events;


public class TurnManager : MonoBehaviour
{
    private State _state;
    [SerializeField] private UnityEvent onEnemyTurn = new UnityEvent();
    [SerializeField] private UIManager ui;
    public Enemie player;
    public Enemie enemie;

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
        }

        else if (_state == State.EnemyTurn)
        {
            _state = State.PlayerTurn;
        }
    }
}