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
    public int P1_HP;
    [HideInInspector] public GameObject postcombat;
    [HideInInspector] public GameObject combat;
    public TextMeshProUGUI UI_CurrentHealth;
    
 

    public void GetHealth()
    {
        P1_HP = HealthbarManager.HP;
    }

    public void StartCombat()
    {
        postcombat.SetActive(false);
        combat.SetActive(true);
        GetHealth();
    }

    public void UpdateUI()
    {
        UI_CurrentHealth.text = P1_HP.ToString();
        
    }

    public void BattleEnd()
    {
        HealthbarManager.HP = P1_HP;
    }
}