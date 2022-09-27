using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLoader : MonoBehaviour
{
    //[HideInInspector] 
    public Enemie _playerInfo;
    private SpriteRenderer _sprite;

    private void Start()
    {
        _sprite = GetComponent<SpriteRenderer>();
        _sprite.sprite = _playerInfo.Artworks;
        
        //geeft ze een collider en size
        BoxCollider2D collider = GetComponent<BoxCollider2D>();
        Vector2 newSize = collider.gameObject.GetComponent<SpriteRenderer>().sprite.bounds.size;
        collider.size = newSize;
    }
}
