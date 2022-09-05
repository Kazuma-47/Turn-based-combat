using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    [SerializeField] private CreatePlayer createplayer;
    private string _name;
    private int _baseHP;
    private int _maxstamina;
    private int _maxmana;


    public Ability[] moves = new Ability[4];
    private void Start()
    {
        _name = createplayer.Name;
        _baseHP = createplayer.maxHP;
        _maxstamina = createplayer.maxstamina;
        _maxmana = createplayer.maxmana;
    }
}
