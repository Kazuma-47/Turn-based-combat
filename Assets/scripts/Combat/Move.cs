using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
[CreateAssetMenu]
public class Move : ScriptableObject
{
    public string name;
    public int damage;
    public int usageLeft;
    public GameObject VFX;

    public string GetInfo()
    {
        return "Damage: " + damage + "\n" + "Usage: " + usageLeft;
    }
}
