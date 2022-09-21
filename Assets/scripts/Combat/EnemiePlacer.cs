using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemiePlacer : MonoBehaviour
{
    public Enemie Enemie1;
    public Enemie Enemie2;
    public static Enemie Enemie;
    public int min;
    public int max;
    private void Start()
    {
        Debug.Log(Enemie);
        Debug.Log(Enemie.Levelen);
    }
    private void Update()
    {
        if (Input.GetKey("w"))
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
        SceneManager.LoadScene(1);
    }
    public void Win() 
    {
        SceneManager.LoadScene(0);
    }
}
