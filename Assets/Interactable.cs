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
    [SerializeField] private UnityEvent onUsed = new UnityEvent();  //will play to trigger a even when interacting with something
    [SerializeField] private UnityEvent onUnused = new UnityEvent(); // will play an event when you can no longer interact with something or reset it to its default state

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
        if(automatic && inRange)onUsed.Invoke();        //if its automatic it will activate every frame 
        if (automatic == false)
        {
            if(inRange && Input.GetKeyUp(KeyCode.E))onUsed.Invoke();        //will wait for the player to interact
        }
    }
}
