using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = System.Object;

public class TeamManager : MonoBehaviour
{
    [SerializeField] private GameObject[] Currentteam = new GameObject[5];

    public void AddMember(GameObject member)
    {
        for (int i = 0; i < Currentteam.Length; i++)
        {
            if (Currentteam[i] != null || Array.Exists(Currentteam, x=> x == member)) continue;
            Currentteam[i] = member;
            break;
        }
    }

    public void RemoveMember(int index)
    {
        Currentteam[index] = null;
    }
}
