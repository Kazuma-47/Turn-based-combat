using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : ScriptableObject
{
    [SerializeField] private string name;
    public Sprite sprite;
    [SerializeField] private bool Interect = false, active = false;


    public void interect()
    {
        if (Input.anyKeyDown)
        {
            Interect = true;
        }
    }
}
