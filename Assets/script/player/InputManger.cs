using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{

    private PlayerInput input;
    private InputAction movementAction;

    public Vector2 MovementInput;


    public bool IsMoving;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Awake()
    {
        IsMoving = false;
        input = GetComponent<PlayerInput>();
        movementAction = input.actions["Move"];

        movementAction.started += movement;
        movementAction.canceled += movement;

    }

    // Update is called once per frame
    void Update()
    {
        MovementInput = movementAction.ReadValue<Vector2>();



    }


    void movement(InputAction.CallbackContext context)
    {
        if (context.started) { IsMoving = true; }
        if (context.canceled){ IsMoving = false; }
    }

    private void OnDestroy()
    {
        movementAction.started -= movement;
        movementAction.canceled -= movement;
    }


}