using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemiePlacer : MonoBehaviour
{
    public Enemie enemy;
    public CreatePlayer player;
    public Enemie[] enemyList;
    public int min;
    public int max;
    public int totalWeigth;

    public void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<CreatePlayer>();
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
        var area = GameObject.Find("Area").GetComponent<Area>();
        totalWeigth = area.totalWeight;
        min = area.min;
        max = area.max;
        EnemieChoser(totalWeigth);
        SceneManager.LoadScene(1);
    }
    public void Win()
    {
        enemy.ExpWin();
        player.player.ExpGet(enemy.expGive);
        SceneManager.LoadScene(4);
    }
    public void EnemieChoser(int totalWeigth)
    {
        var area = GameObject.Find("Area").GetComponent<Area>();
        int weight = Random.Range(1, totalWeigth);
        foreach (var enemy in enemyList)
        {
            Debug.Log(weight);
            if (weight <= enemy.grade)
            {
                enemy.level = Random.Range(area.min, area.max);
                this.enemy = enemy;
                Debug.Log(this.enemy);
                return;
            }
            weight -= enemy.grade;
        }
    }
}
