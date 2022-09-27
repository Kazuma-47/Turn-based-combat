using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemiePlacer : MonoBehaviour
{
    public Enemie Enemie1;
    public Enemie Enemie2;
    public Enemie Enemie;
    public CreatePlayer _Player;
    public int min;
    public int max;
    
    public void Start()
    {
        _Player = GameObject.FindWithTag("Player").GetComponent<CreatePlayer>();
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
        EnemieChoser();
        DontDestroyOnLoad(this.gameObject);
        SceneManager.LoadScene(1);
    }
    public void Win() 
    {
        Enemie.EXPWin();
        _Player.player.EXPGet(Enemie.EXPGive);
        SceneManager.LoadScene(0);
    }
    public void EnemieChoser()
    {
        int ene = Random.Range(0, 20);

        if (ene >= 10)
        {
            Enemie = Enemie1;
        }
        else
        {
            Enemie = Enemie2;
        }
        Enemie.Level(min, max);
    }
}
