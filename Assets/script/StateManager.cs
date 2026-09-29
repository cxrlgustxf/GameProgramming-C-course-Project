using UnityEngine;

public class StateManager : MonoBehaviour
{

    public Movement movement;
    public Rigidbody2D rb;
    public Animations animations;

<<<<<<< HEAD
=======
    public Projectile projectile;

>>>>>>> parent of dd69405 (StateMachine abstract class implemented)
    IState _currentState;
    void Awake()
    {
        movement = new Movement();
        rb = GetComponent<Rigidbody2D>();
        animations = GetComponent<Animations>();

    }


    void Update()
    {
        _currentState.UpdateState(this);
    }


    void ChangeState(IState newState)
    {
        _currentState.ExitState(this);

        _currentState = newState;

        _currentState.EnterState(this);

    }
}
