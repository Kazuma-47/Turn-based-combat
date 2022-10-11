using System;
using System.Collections.Generic;
using System.Linq;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Events;


public class SpawnEntities : DisplayCharacter
{
    #region Declarations  //helpt met het sorteren naar code
    [SerializeField] private GameObject baseEntity;
    //[SerializeField] private CreatePlayer[] _availableUnits;
    [SerializeField] private Enemie _availableUnits;
    [SerializeField] private Players _player;
    [SerializeField] private Transform playerslot;
    public TurnManager turnManager;
    #endregion

    #region Start/Update functions
    private void Start()
    {
        GetBattleInfo();
    }
    #endregion
    #region Get info and spawn entities   
    public void GetBattleInfo()
    {
        GameObject Info = GameObject.FindWithTag("Ground");
        _availableUnits = Info.GetComponent<EnemiePlacer>().enemy;
        Info = GameObject.FindWithTag("Player");
        _player = Info.GetComponent<CreatePlayer>()._player;
        SpawnDemo();
    }

    public void SpawnDemo()
    {
        var PlayerCharacter = Instantiate(baseEntity, playerslot.transform.position, quaternion.identity, playerslot);
        
        PlayerCharacter.GetComponent<CharacterLoader>().entity = CharacterLoader.Entity.player;
        PlayerCharacter.GetComponent<CharacterLoader>()._playerInfo = _player;
        PlayerCharacter.gameObject.tag = "PlayerUnit";
        turnManager.player = _player;
        
        

        var character2 = Instantiate(baseEntity, slots[0].transform.position, quaternion.identity,slots[0]);
        character2.GetComponent<CharacterLoader>()._enemieInfo = _availableUnits;
        turnManager.enemy = _availableUnits;
        character2.gameObject.tag = "EnemyUnit";
    }
    #endregion
    #region Unused code
    public void SpawnCharacters(Enemie player,Enemie[] enemies)
    {
        for (int i = 0; i < enemies.Length; i++)
        {
            var character = Instantiate(baseEntity, slots[i].transform.position, Quaternion.identity, slots[i]);
            character.GetComponent<CharacterLoader>()._enemieInfo = enemies[i];
        }
        print("spawnPlayer");
         var character2 = Instantiate(baseEntity, playerslot.transform.position, quaternion.identity,playerslot);
         character2.GetComponent<CharacterLoader>()._enemieInfo = player;
    }
    #endregion
    
}

    
    

