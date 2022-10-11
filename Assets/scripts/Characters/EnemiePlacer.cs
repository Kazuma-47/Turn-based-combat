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
        EnemieChoser(totalWeigth);
        SceneManager.LoadScene("Combat");
    }
    public void Win()
    {
        player._player.ExpGet(enemy.EXPWin());
        SceneManager.LoadScene(0);
    }
    public void EnemieChoser(int _totalWeigth)
    {
        int _weight = Random.Range(1, _totalWeigth);
        foreach (var _enemy in enemyList)
        {
            if (_weight <= _enemy.grade)
            {
                _enemy.level = Random.Range(min, max);
                this.enemy = _enemy;
                this.enemy.Stats();
                return;
            }
            _weight -= _enemy.grade;
        }
    }
}
