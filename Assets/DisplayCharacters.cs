using System.Collections.Generic;
using UnityEngine;

public class DisplayCharacter : MonoBehaviour
{
    [SerializeField] protected List<Transform> slots = new List<Transform>();

    private void Awake()
    {
        var childObjects = gameObject.GetComponentsInChildren<Transform>();
        foreach (var childObject in childObjects)
        {
            if (childObject.transform == gameObject.transform) continue; //so he doesnt add the parent of the object to the list
            slots.Add(childObject);
        }
    }

    public virtual void InstantiateTeam(GameObject[] team )
    {
        CleanSlots();
        for (int i = 0; i < team.Length; i++)
        {
            if (team[i] == null) continue;
            
            Instantiate(team[i], slots[i].transform);
        }
    }

    private void CleanSlots()
    {
        foreach (var slot in slots)
        {
            if(slot.transform.childCount > 0) Destroy(slot.GetChild(0).gameObject); 
        }
    }
} 