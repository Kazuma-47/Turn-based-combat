using System;
using System.Collections.Generic;
using System.Linq;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Events;


public class SpawnEntities : DisplayCharacter
{
    #region getters & setters //helpt met het sorteren naar code
    [SerializeField] private GameObject baseEntity;
    //[SerializeField] private CreatePlayer[] _availableUnits;
    [SerializeField] private Enemie _availableUnits;
    [SerializeField] private Enemie _player;
    [SerializeField] private Transform playerslot;
    public TurnManager turnManager;




    #endregion


    private void Start()
    {
        GetBattleInfo();
    }
    
    public void GetBattleInfo()
    {
        GameObject[] Info = GameObject.FindGameObjectsWithTag("Ground");
        _availableUnits = Info[0].GetComponent<EnemiePlacer>().enemy;
        SpawnDemo();
    }

    public void SpawnDemo()
    {
        
        
        var PlayerCharacter = Instantiate(baseEntity, playerslot.transform.position, quaternion.identity, playerslot);
        PlayerCharacter.GetComponent<CharacterLoader>()._playerInfo = _player;
        turnManager.player = _player;
        
        var character2 = Instantiate(baseEntity, slots[0].transform.position, quaternion.identity,slots[0]);
        character2.GetComponent<CharacterLoader>()._playerInfo = _availableUnits;
        turnManager.enemie = _availableUnits;
    }
    
    
    public void SpawnCharacters(Enemie player,Enemie[] enemies)
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

    
    
