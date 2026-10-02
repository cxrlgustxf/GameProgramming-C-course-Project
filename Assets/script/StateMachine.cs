using UnityEngine;

public class StateMachine : MonoBehaviour
{



    public Movement movement;
    public Enemy enemy;
    public Player player;

    IState _currentState;

    public StateMove stateMove;
    public StateIdle stateIdle;

    void Awake()
    {
        

        enemy = GetComponent<Enemy>();
        player = GetComponent<Player>();

        stateMove = new StateMove();
        stateIdle = new StateIdle();

        movement = new Movement();
        if (player != null)
        {
            _currentState = stateIdle;
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
