using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{   
    #region Variables
    [SerializeField] 
    private bool automatic, inRange;
    [SerializeField] private UnityEvent onUsed = new UnityEvent();  //will play to trigger a even when interacting with something
    [SerializeField] private UnityEvent onUnused = new UnityEvent(); // will play an event when you can no longer interact with something or reset it to its default state
    #endregion

    #region  physics
    private void OnTriggerEnter2D(Collider2D _other)
    {
        if (_other.CompareTag("PlayerUnit")) inRange = true;
    }
    private void OnTriggerExit2D(Collider2D _other)
    {
        inRange = false;
        onUnused.Invoke();
    }
    #endregion
    
    #region StartUp
    private void Update()
    {
        if(automatic && inRange)onUsed.Invoke();        //if its automatic it will activate every frame 
        if (automatic == false)
        {
            if(inRange && Input.GetKeyUp(KeyCode.E))onUsed.Invoke();        //will wait for the player to interact
        }
    }
    #endregion
}
