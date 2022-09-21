using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLoader : MonoBehaviour
{
    [HideInInspector] public CreatePlayer _playerInfo;
    private SpriteRenderer _sprite;

    private void Start()
    {
        _sprite = GetComponent<SpriteRenderer>();
        _sprite.sprite = _playerInfo.sprite;
    }
}
