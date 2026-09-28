using UnityEngine;

public class player : MonoBehaviour
{


    public Animations animations;
    public InputManager input;

    public Movement movement;

    public Rigidbody2D rb;



    void Awake()
    {
       animations = GetComponent<Animations>();
       input = GetComponent<InputManager>();
       rb = GetComponent<Rigidbody2D>();
       
       movement = new Movement();
       
    }


    void Update()
    {

        MoveAndAnimate();

    }

    void MoveAndAnimate()
    {


        animations.SetAnimation(input.MovementInput.x, input.MovementInput.y);

        if (input.MovementInput != Vector2.zero)
        {
            
            rb.linearVelocity = movement.GetMovement(input.MovementInput, 10f);
        }
        else
        {
            rb.linearVelocity = Vector2.zero;
        }
    }
}
