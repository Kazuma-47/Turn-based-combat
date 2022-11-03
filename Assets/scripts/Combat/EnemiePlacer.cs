using UnityEngine;
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
        foreach (var _enemy in enemyList)
        {
            if (_weight <= _enemy.grade)
            {
                Debug.Log(_enemy);
                _enemy.level = Random.Range(min, max);
                this.enemy = _enemy;
                this.enemy.Stats();
                return;
            }
            _weight -= _enemy.grade;
        }
    }
}
