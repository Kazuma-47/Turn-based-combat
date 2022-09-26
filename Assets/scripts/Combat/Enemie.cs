using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Enemie : ScriptableObject
{
    public string Name;
    public Sprite Artworks;
    public int Health;
    public static int Levelen;
    public Enemie Vijand;
    public Move[] moves = new Move[3];
    public void SetLevel(int Level)
    {
        Levelen = Level;
    }
}