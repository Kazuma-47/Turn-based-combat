using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class DisplayTeam : MonoBehaviour
{
    [SerializeField] private List<Transform> Slots = new List<Transform>();

    private void Awake()
    {
        var childObjects = gameObject.GetComponentsInChildren<Transform>();
        foreach (var childObject in childObjects)
        {
            if (childObject == gameObject.transform) continue; //so he doesnt add the parent of the object to the list
            Slots.Add(childObject);
        }
    }

    public void InstantiateTeam(GameObject[] team )
    {
        for (int i = 0; i < team.Length; i++)
        {
            if (team[i] == null) continue;
            Instantiate(team[i], Slots[i]);
        }
    }
    
}
