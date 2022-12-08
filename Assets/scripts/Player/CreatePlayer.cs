using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlayer : MonoBehaviour
{
    public Players _player;
    public Player _body;
    private Vector3 spawnPos;
    public void Start() 
    {
        DontDestroyOnLoad(this.gameObject);
        _player.StartUp();
    }
    public void SafePos()
    {
        spawnPos = _body.transform.position;
    }
    public void Spawn()
    {
        _body.transform.position = spawnPos;
    }
}
