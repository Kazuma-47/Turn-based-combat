using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class CreatePlayer : MonoBehaviour
{
    public Players _player;
    public GameObject player;
    public Vector3 posBeforeCombat;
    public void Start() 
    {
        DontDestroyOnLoad(this.gameObject);
        _player.StartUp();
        player = GameObject.Find("Player");
    }

    public Vector3 UpdatePos(Transform pos)
    {
        posBeforeCombat = pos.transform.position;
            return pos.transform.position;
    }
    
}
