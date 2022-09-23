using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Enemie : BaseCharacter
{
    public int EXPGive;
    public static int Levelen;

    public void SetLevel(int Level)
    {
        Levelen = Level;
    }
}
