using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlayer : MonoBehaviour
{
    public Players player;
    public void Start() 
    {
        DontDestroyOnLoad(this.gameObject);
        player.startUp();
    }
}
