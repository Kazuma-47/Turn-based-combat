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
    public int min;
    public int max;

    private void Update()
    {
        if (Input.GetKey("w"))
        {
            Encounter();
            Debug.Log(Enemie.Levelen);
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
        SceneManager.LoadScene(0);
    }
    public void EnemieChoser()
    {
        int ene = Random.Range(0, 20);
        int Level = Random.Range(min, max);
        if (ene >= 10)
        {
            Enemie = Enemie1;
        }
        else
        {
            Enemie = Enemie2;
        }
        Enemie.SetLevel(Level);
    }
}
