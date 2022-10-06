using UnityEngine;
using UnityEngine.UIElements;

public class HealthbarManager : MonoBehaviour
{
    public void HealthbarUpdate()
    {
        var _enemyList = GameObject.FindGameObjectsWithTag("EnemyUnit");        //finds every enemy in the scene and puts it in an array
        var _player = GameObject.FindWithTag("PlayerUnit");

        foreach (var enemy in _enemyList)
        {
            enemy.GetComponent<CharacterLoader>().UpdateCurrenthealth();
        }
        _player.gameObject.GetComponent<CharacterLoader>().UpdateCurrenthealth();
    }

}


