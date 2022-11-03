using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Area : MonoBehaviour
{
    #region Variables
    private EnemiePlacer placer;
    [SerializeField] private Enemie[] enemyList;
    [SerializeField] private int[] gradesList; // lijst  met gewichten van enemies
    [SerializeField] private int min, max; // minimum level van enemy en maximum level van de enemy.
    private int totalWeight; // totaal gewicht van alle enemies
    private int i; // index
    #endregion

    #region StartUp
    public void Start()
    {
        placer = GameObject.Find("placer").GetComponent<EnemiePlacer>();
        CalculateWeight();
        SetEnemieStats();
    }
    #endregion

    #region Functies
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
    #endregion
}
