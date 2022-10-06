using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Area : MonoBehaviour
{
    public EnemiePlacer placer;
    public Enemie[] enemies;
    public int min;
    public int max;
    public int[] grades;
    public int totalWeight;
    private int i;

    public void Start()
    {
        foreach (var enemy in enemies)
        {
            enemy.grade = grades[i];
            i += 1;
        }
        placer = GameObject.Find("placer").GetComponent<EnemiePlacer>();
        foreach (var enemie in enemies)
        {
            totalWeight += enemie.grade;
        }
        Debug.Log(totalWeight);
        placer.enemyList = enemies;
        placer.TotalWeigth = totalWeight;
        placer.enemyList = enemies;
        placer.min = min;
        placer.max = max;

    }


}
