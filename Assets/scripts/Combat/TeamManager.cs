using System;
using UnityEngine;
using UnityEngine.Events;


public class TeamManager : MonoBehaviour
{
    [SerializeField] private int teamSize =5 ;
    [SerializeField] private GameObject[] currentTeam;
    [SerializeField] private UnityEvent<GameObject[]> Team = new UnityEvent<GameObject[]>();

    private void Awake()
    {
        currentTeam = new GameObject[teamSize];
    }


    public void CheckSlots(GameObject member)
    {
        for (int i = 0; i < currentTeam.Length; i++)
        {
            //Check if the character has already been added to the array
            if (Array.Exists(currentTeam, x => x == member))
            {
                int index = currentTeam.findIndex(member);
                RemoveMember(index);    print("found in array");   
                break; 
            }
            //if character slot is used and character is not already in the array check the next
            if (currentTeam[i] != null) continue;   
                AddMember(i,member);
                break;
            
        }

    }
    public void AddMember(int index ,GameObject member)
    {
            currentTeam[index] = member;
            Team.Invoke(currentTeam);
    }

    public void ClearTeam()
    {
        print("cleared");
        currentTeam.ClearArray();
        Team.Invoke(currentTeam);
    }
    
    public void RemoveMember(int index)
    {
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
