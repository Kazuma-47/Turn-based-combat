using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    [SerializeField] private CreatePlayer createplayer;
    private string _name;
    private int _maxHP;
    private int _maxstamina;
    private int _maxmana;
    private int _currentHealth;

    public Ability[] moves = new Ability[4];
    private void Start()
    {
        _name = createplayer.Name;
        _maxHP = createplayer.maxHP;
        _maxstamina = createplayer.maxstamina;
        _maxmana = createplayer.maxmana;
        
    }
}
