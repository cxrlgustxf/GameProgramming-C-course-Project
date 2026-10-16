using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class InputManager : MonoBehaviour
{

    private PlayerInput input;
    private InputAction movementAction;
    private InputAction pauseAction;

    public Vector2 MovementInput;


    public bool IsMoving;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Awake()
    {
        IsMoving = false;
        input = GetComponent<PlayerInput>();
        
    }

    void Start()
    {
        
        movementAction = input.actions["Move"];
        pauseAction = input.actions["Pause"];

        movementAction.started += movement;
        movementAction.canceled += movement;

        pauseAction.started += pauseGame;
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


    void pauseGame(InputAction.CallbackContext context)
    {

        if (!SceneManager.GetSceneByName("PauseMenu").IsValid())
        {
            SceneManager.LoadScene("PauseMenu", LoadSceneMode.Additive);
        }
        else
        {
            Time.timeScale = 1.0f;
            SceneManager.UnloadSceneAsync("PauseMenu");
        }
        
    }

    private void OnDestroy()
    {
        movementAction.started -= movement;
        movementAction.canceled -= movement;
    }


}