using System;
using UnityEngine;


public class TeamManager : MonoBehaviour
{
    [SerializeField] private GameObject[] currentTeam = new GameObject[5];

    public void AddMember(GameObject member)
    {
        for (int i = 0; i < currentTeam.Length; i++)
        {
            if (currentTeam[i] != null || Array.Exists(currentTeam, x=> x == member)) continue;
            currentTeam[i] = member;
            break;
        }
    }

    public void RemoveMember(int index)
    {
        currentTeam[index] = null;
    }
 
}
