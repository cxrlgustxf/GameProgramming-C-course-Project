using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{

    private PlayerInput input;
    private InputAction movementAction;

    public Vector2 MovementInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Awake()
    {
        input = GetComponent<PlayerInput>();
        movementAction = input.actions["Move"];


    }

    // Update is called once per frame
    void Update()
    {
        MovementInput = movementAction.ReadValue<Vector2>();



    }







}