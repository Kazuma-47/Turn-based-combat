using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;
using TMPro;


public class TurnManager : MonoBehaviour
{
    private State _state;
    [SerializeField] private UIManager ui;
    private enum State
    {
        PlayerTurn,
        EnemyTurn
    }

    public int health;

    public void Start()
    {
        print(health);
    }

    private void Update()
    {

        if (_state == State.PlayerTurn)
        {
            ui.ChangeUIAtk();
        }
        else if (_state == State.EnemyTurn)
        {
            ui.ChangeUIMenu();
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