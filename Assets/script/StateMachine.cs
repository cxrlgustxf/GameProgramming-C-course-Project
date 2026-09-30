using UnityEngine;

public class StateMachine : MonoBehaviour
{

    public Animations animations;
    public InputManager input;

    public Movement movement;
    public Enemy enemy;
    public Rigidbody2D rb;
    IState _currentState;

    StateChase stateChase;

    void Awake()
    {
        
        animations = GetComponent<Animations>();
        input = GetComponent<InputManager>();
        rb = GetComponent<Rigidbody2D>();
        enemy = GetComponent<Enemy>();

        stateChase = new StateChase();


        movement = new Movement();
        if (input != null)
        {
            _currentState = stateChase;
        }
        

    }



    void Update()
    {
        _currentState.UpdateState(this);
    }


    public void ChangeState(IState newState)
    {
        _currentState.ExitState(this);

        _currentState = newState;

        _currentState.EnterState(this);

    }
}
