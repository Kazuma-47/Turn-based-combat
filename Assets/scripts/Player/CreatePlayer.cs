using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="Character Name" , menuName = "character stats")]
public class CreatePlayer : ScriptableObject
{
    public string Name;
    public int maxHP;
    public int lvl;

    public int[] MoveIds = new int[4];

}
