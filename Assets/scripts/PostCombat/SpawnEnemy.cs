using System;
using System.Linq;
using Unity.Mathematics;
using UnityEngine;


public class SpawnEnemy : DisplayCharacter
{
    #region getters & setters //helpt met het sorteren naar code
    [SerializeField] private GameObject baseEntity;
    [SerializeField] private CreatePlayer[] _availableUnits;
    [SerializeField] private CreatePlayer _player;
    [SerializeField] private GameObject playerslot;


    #endregion


    private void Start()
    {
        SpawnEntities(_player,_availableUnits);
    }

    public void GetBattleInfo(CreatePlayer player, CreatePlayer[] enemies)
    {
        _player = player;
        _availableUnits = enemies;
    }

    public void SpawnEntities(CreatePlayer player,CreatePlayer[] enemies)
    {
        for (int i = 0; i < enemies.Length; i++)
        {
            Instantiate(baseEntity, slots[i].transform.position, Quaternion.identity, slots[i]);
        }
        Instantiate(baseEntity, playerslot.transform.position, quaternion.identity);
    }

    
}

    
    

