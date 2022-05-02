using System;
using UnityEngine;


public class TeamManager : MonoBehaviour
{
    [SerializeField] private int teamSize;
    [SerializeField] private GameObject[] currentTeam;

    private void Awake()
    {
        currentTeam = new GameObject[teamSize];
    }

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

    public void ResizeArray()
    {
        //store old array incase u need to change it mid Post Combat
        var oldArrayValues = currentTeam;
        currentTeam = new GameObject[teamSize];
        
        //adds old values to new array so you dont resize it
        for (int i = 0; i < oldArrayValues.Length ; i++)
        {
            currentTeam[i] = oldArrayValues[i];
        }
    }
}
