using UnityEngine;
using UnityEngine.UIElements;

public class HealthbarManager : MonoBehaviour
{
    public void HealthbarUpdate()
    {
        var EnemyList = GameObject.FindGameObjectsWithTag("EnemyUnit");
        var Player = GameObject.FindWithTag("PlayerUnit");

        foreach (var enemy in EnemyList)
        {
            enemy.GetComponent<CharacterLoader>().UpdateCurrenthealth();
        }
        Player.gameObject.GetComponent<CharacterLoader>().UpdateCurrenthealth();
    }

}


