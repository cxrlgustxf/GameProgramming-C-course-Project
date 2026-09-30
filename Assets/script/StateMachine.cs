using UnityEngine;

public class StateMachine : MonoBehaviour
{



    public Movement movement;
    public Enemy enemy;
    public Player player;

    IState _currentState;

    StateMove stateChase;

    void Awake()
    {
        

        enemy = GetComponent<Enemy>();
        player = GetComponent<Player>();

        stateChase = new StateMove();


        movement = new Movement();
        if (player != null)
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
