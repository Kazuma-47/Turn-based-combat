using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlayer : MonoBehaviour
{
    public Players _player;
    public void Start() 
    {
        DontDestroyOnLoad(this.gameObject);
        _player.StartUp();
    }
}
