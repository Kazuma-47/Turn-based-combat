using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemiePlacer : MonoBehaviour
{
    public Enemie Enemie;
    public CreatePlayer _Player;
    public Enemie[] enemyList;
    public int min;
    public int max;
    public int TotalWeigth;

    public void Start()
    {
        _Player = GameObject.FindWithTag("Player").GetComponent<CreatePlayer>();
        foreach (var Enemie in enemyList)
        {
            TotalWeigth +=Enemie.grade;
        }
        Debug.Log(TotalWeigth);
    }
    private void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            EnemieChoser(TotalWeigth);
        }
        if (Input.GetKey("e"))
        {
            Win();
        }
    }
    public void Encounter()
    {
        EnemieChoser(TotalWeigth);
        DontDestroyOnLoad(this.gameObject);
        SceneManager.LoadScene(1);
    }
    public void Win()
    {
        _Player.player.EXPGet(Enemie.EXPWin());
        SceneManager.LoadScene(0);
    }
    public void EnemieChoser(int totalWeigth)
    {
        int weight = Random.Range(1, totalWeigth);
        foreach (var enemy in enemyList)
        {
            if (weight <= enemy.grade)
            {
                enemy.Levelen = Random.Range(min, max);
                Enemie = enemy;
                Debug.Log(Enemie);
                return;
            }
            weight -= enemy.grade;
        }
    }
}
