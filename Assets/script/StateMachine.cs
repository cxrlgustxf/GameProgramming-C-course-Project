using UnityEngine;

public class StateMachine : MonoBehaviour
{



    public Movement movement;
    public Enemy enemy;
    public Player player;

    public WorldManager worldManager;

    IState _currentState;



    void Awake()
    {
        

        enemy = GetComponent<Enemy>();
        player = GetComponent<Player>();
        worldManager = GetComponent<WorldManager>();

    
        movement = new Movement();
        if (player != null)
        {
            _currentState = player.stateIdle;
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
