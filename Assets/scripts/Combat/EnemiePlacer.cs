using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemiePlacer : MonoBehaviour
{
    public Enemie enemy;
    public CreatePlayer player;
    public Encounters[] enemyList;
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
        if (Input.GetKey("e"))
        {
            Win();
        }
    }
    public void Encounter()
    {
        EnemieChoser(totalWeigth);
        SceneManager.LoadScene("Combat");
    }
    public void Win()
    {
        player._player.ExpGet(enemy.EXPWin());
        SceneManager.LoadScene(1);
    }
    public void EnemieChoser(int _totalWeigth)
    {
        int _weight = Random.Range(1, _totalWeigth);
        foreach (Encounters _enemy in enemyList)
        {
            Debug.Log("shit balls");
            if (_weight <= _enemy.grade)
            {
                _enemy.enemy.level = Random.Range(min, max);
                this.enemy = _enemy.enemy;
                this.enemy.Stats();
                return;
            }
            _weight -= _enemy.grade;
        }
    }
}