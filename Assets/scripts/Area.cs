using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Area : MonoBehaviour
{
    private EnemiePlacer placer;

    [SerializeField] private Enemie[] enemyList;
    [SerializeField] private int[] gradesList;
    [SerializeField] private int min;
    [SerializeField] private int max;
    private int totalWeight;
    private int i;

    public void Start()
    {
        placer = GameObject.Find("placer").GetComponent<EnemiePlacer>();
        CalculateWeight();
        SetEnemieStats();


    }
    public void CalculateWeight()
    {
        foreach (var _enemy in enemyList)
        {
            _enemy.grade = gradesList[i];
            i += 1;
        }

        foreach (var _enemy in enemyList)
        {
            totalWeight += _enemy.grade;
        }
    }
    public void SetEnemieStats()
    {
        placer.totalWeigth = totalWeight;
        placer.enemyList = enemyList;
        placer.min = min;
        placer.max = max;
    }

}
