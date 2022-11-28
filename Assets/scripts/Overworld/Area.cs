using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Encounters
{
    public Enemie enemy;
    public int grade;
}


public class Area : MonoBehaviour
{
    private EnemiePlacer placer;
    public Encounters[] encounters;
    [SerializeField] private int levelMin,levelMax;
    private int totalWeight;
    public void Start()
    {
        placer = GameObject.Find("placer").GetComponent<EnemiePlacer>();
        CalculateWeight();
        SetEnemieStats();
    }
    public void CalculateWeight()
    {
        foreach (var _encounter in encounters)
        {
            totalWeight += _encounter.grade;
        }
    }
    public void SetEnemieStats()
    {
        placer.totalWeigth = totalWeight;
        placer.min = levelMin;
        placer.max = levelMax;
    }

}
