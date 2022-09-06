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


    private float HpScale = 1.025f;
    public int health;
    public int IntHP;
    public float FloatHP;

    public void Start()
    {
        GetHealth();
        print(health);
    }
    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            health = health - 5;
            BattleEnd();
        }

    }
    public void GetHealth()
    {
        health = CharacterStats.HP;
        FloatHP = Mathf.Pow(HpScale, CharacterStats.monsterLVL) * CharacterStats.monsterHP;
        IntHP = (int)Math.Round(FloatHP);
    }
    public void BattleEnd()
    {
        CharacterStats.HP = health;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}