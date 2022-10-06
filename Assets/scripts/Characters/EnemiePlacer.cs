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
        DontDestroyOnLoad(this.gameObject);
    }
    private void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            Encounter();
        }
        if (Input.GetKey("e"))
        {
            Win();
        }
    }
    public void Encounter()
    {
        EnemieChoser(TotalWeigth);
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
                Enemie.Stats();
                Debug.Log(Enemie);
                return;
            }
            weight -= enemy.grade;
        }
    }
}
