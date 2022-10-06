using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Area : MonoBehaviour
{
    private EnemiePlacer _placer;

    [SerializeField] private Enemie[] enemyList;
    [SerializeField] private int[] gradesList;
    [SerializeField] private int min;
    [SerializeField] private int max;
    private int totalWeight;
    private int i;

    public void Start()
    {
        foreach (var enemy in enemyList)
        {
            enemy.grade = gradesList[i];
            i += 1;
        }
        _placer = GameObject.Find("placer").GetComponent<EnemiePlacer>();
        foreach (var enemy in enemyList)
        {
            totalWeight += enemy.grade;
        }

        SetEnemieStats();

    }
    public void SetEnemieStats()
    {
        _placer.totalWeigth = totalWeight;
        _placer.enemyList = enemyList;
        _placer.min = min;
        _placer.max = max;
    }

}
