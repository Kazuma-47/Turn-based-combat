using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    [SerializeField] private CreatePlayer createplayer;
    public static int HP = 40;

    public static int monsterLVL = 30;
    public static int monsterHP = 30;


    public int[] moves = new int[4];
}
