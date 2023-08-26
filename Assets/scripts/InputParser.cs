using UnityEngine;
using UnityEngine.InputSystem;

public class InputParser : MonoBehaviour
{
    [Header("Input Map")]
    private PlayerControls controls;
    private Movement _playerMovement;
    private Collider2D playerCollider;

    // get input map and all components needed
    public void Awake()
    {
        playerCollider = GetComponent<Collider2D>();
        controls = new PlayerControls();
        _playerMovement = GetComponent<Movement>();
    }

    // Handle inputs
    private void FixedUpdate()
    {
        if (Gamepad.current != null)
        {
            controls.Controller.Jump.performed += (InputAction.CallbackContext context) => _playerMovement.Jump();
            // Controller input
            Vector2 moveInput = controls.Controller.Move.ReadValue<Vector2>();
            _playerMovement.Run(1.0f, moveInput);
        }
        else
        {
            
            controls.PC.Jump.performed += (InputAction.CallbackContext context) => _playerMovement.Jump();
            //let him crouch
            if (controls.PC.Crouch.ReadValue<float>() > 0.5f) //gpt is kkr geil
            {
                _playerMovement.Crouch();
            }  
            // Keyboard input
            Vector2 moveInput = controls.PC.Move.ReadValue<Vector2>();
            _playerMovement.Run(0.6f, moveInput);
            controls.PC.Dash.performed += (InputAction.CallbackContext context) => _playerMovement.Dash(moveInput); //vraag gpt voor optimalisatie want moveinput ophalen laat het laggen


        }

    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
}
