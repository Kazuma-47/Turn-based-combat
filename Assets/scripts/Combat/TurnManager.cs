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
        if (Input.GetKeyDown("space"))
        {
            health = health - 5;
        }

    }
}