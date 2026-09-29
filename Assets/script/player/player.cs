using UnityEngine;

public class Player : MonoBehaviour
{


    public Animations animations;
    public InputManager input;

    public Movement movement;

    public Rigidbody2D rb;

    public PlayerStateMachine stateManager;

    void Awake()
    {
       animations = GetComponent<Animations>();
       input = GetComponent<InputManager>();
       rb = GetComponent<Rigidbody2D>();
       
       movement = new Movement();
       
    }


    void Update()
    {
        stateManager.FetchContext(this.gameObject);
        stateManager.UpdateStateManager();
    }

    void MoveAndAnimate()
    {
        Vector2 lastMovement;

        animations.SetAnimation(input.MovementInput.x, input.MovementInput.y);

        if (input.MovementInput != Vector2.zero)
        {
            lastMovement = input.MovementInput;
            rb.linearVelocity = movement.GetMovement(input.MovementInput, 10f);
        }
        else
        {
            rb.linearVelocity = Vector2.zero;
        }

      
    }

}
