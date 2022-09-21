using System;
using System.Linq;
using Unity.Mathematics;
using UnityEngine;


public class SpawnEntities : DisplayCharacter
{
    #region getters & setters //helpt met het sorteren naar code
    [SerializeField] private GameObject baseEntity;
    [SerializeField] private CreatePlayer[] _availableUnits;
    [SerializeField] private CreatePlayer _player;
    [SerializeField] private Transform playerslot;


    #endregion


    private void Start()
    {
        SpawnCharacters(_player,_availableUnits);
    }

    public void GetBattleInfo(CreatePlayer player, CreatePlayer[] enemies)
    {
        _player = player;
        _availableUnits = enemies;
    }

    public void SpawnCharacters(CreatePlayer player,CreatePlayer[] enemies)
    {
        for (int i = 0; i < enemies.Length; i++)
        {
            var character = Instantiate(baseEntity, slots[i].transform.position, Quaternion.identity, slots[i]);
            character.GetComponent<CharacterLoader>()._playerInfo = enemies[i];
        }
        print("spawnPlayer");
         var character2 = Instantiate(baseEntity, playerslot.transform.position, quaternion.identity,playerslot);
         character2.GetComponent<CharacterLoader>()._playerInfo = player;
    }

    
}

    
    

