using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    [SerializeField] 
    private bool automatic;
    private bool inRange;
    [SerializeField] private UnityEvent onUsed = new UnityEvent();
    [SerializeField] private UnityEvent onUnused = new UnityEvent();

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PlayerUnit")) inRange = true;
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        inRange = false;
        onUnused.Invoke();
    }

    private void Update()
    {
        if(automatic && inRange)onUsed.Invoke();
        if (automatic == false)
        {
            if(inRange && Input.GetKeyUp(KeyCode.E))onUsed.Invoke();
        }
    }
}
