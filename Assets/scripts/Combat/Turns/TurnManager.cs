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
using UnityEngine.PlayerLoop;


public class TurnManager : MonoBehaviour
{
    public Moves moves;
    public int P1_HP;
    public TextMeshProUGUI UI_CurrentHealth;
    public Slider enemyHealth;
    public Slider playerHealth;
    public int enemyhp =20;


    private void Start()
    {
        GetHealth();
    }

    public void GetHealth()
    {
        P1_HP = HealthbarManager.HP;
        
    }
    public void StartCombat()
    {
        GetHealth();
    }

    public void Attack(int MoveID)
    {
        if (MoveID == 1)
        {
            enemyhp = moves.use(MoveID, enemyhp , (int)Math.Round(enemyHealth.maxValue));
        }
        else if (MoveID == 2)
        {
             P1_HP = moves.use(MoveID, P1_HP, (int) Math.Round(playerHealth.maxValue));

        }
       
    }
    public void Update()
    {
        playerHealth.value = P1_HP;
        UI_CurrentHealth.text = P1_HP.ToString();
        enemyHealth.value = enemyhp;
        
    }

    public void BattleEnd()
    {
        HealthbarManager.HP = P1_HP;
    }
}