using UnityEngine;

public class StateManager : MonoBehaviour
{

    public Animations animations;
    public InputManager input;

    public Movement movement;

    public Vector2 Target;
    public Rigidbody2D rb;
    IState _currentState;

    StateChase stateChase;

    void Awake()
    {
        
        animations = GetComponent<Animations>();
        input = GetComponent<InputManager>();
        rb = GetComponent<Rigidbody2D>();


        stateChase = new StateChase();


        movement = new Movement();
        _currentState = stateChase;

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
