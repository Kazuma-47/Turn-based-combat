using System;
using UnityEngine;
using UnityEngine.Events;


public class TeamManager : MonoBehaviour
{
    [SerializeField] private int teamSize;
    [SerializeField] private GameObject[] currentTeam;
    [SerializeField] private UnityEvent<GameObject[]> Team = new UnityEvent<GameObject[]>();

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
            Team.Invoke(currentTeam);
            break;
        }
    }

    public void RemoveMember(int index)
    {
        print("active");
        currentTeam[index] = null;
        Team.Invoke(currentTeam);
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
