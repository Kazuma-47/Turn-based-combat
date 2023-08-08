using UnityEngine;
using UnityEngine.InputSystem;

public class InputParcer : MonoBehaviour
{
    public InputActionAsset inputActions;

    // get input map and all components needed
    public void Awake()
    {
        inputActions = GetComponent<PlayerInput>().actions;
    }
    //handle inputs
    private void FixedUpdate()
    {
        inputActions["Jump"].performed += (InputAction.CallbackContext context) => Jump();
        _moveInput = inputActions["Move"].ReadValue<Vector2>();
        Run(1);
    }
}
