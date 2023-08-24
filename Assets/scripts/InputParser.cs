using UnityEngine;
using UnityEngine.InputSystem;

public class InputParser : MonoBehaviour
{
    [Header("Input Map")]
    private PlayerControls controls;
    private Movement _playerMovement;

    // get input map and all components needed
    public void Awake()
    {
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
            // Keyboard input
            Vector2 horizontalInput = controls.PC.Move.ReadValue<Vector2>();
            _playerMovement.Run(0.6f, horizontalInput);
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
