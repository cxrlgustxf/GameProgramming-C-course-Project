using UnityEngine;

public class StateMachine : MonoBehaviour
{



    public Movement movement;
    public Enemy enemy;
    public Player player;

    public WorldManager worldManager;

    IState _currentState;

    private void Awake()
    {
        enemy = GetComponent<Enemy>();
        player = GetComponent<Player>();
        worldManager = GetComponent<WorldManager>();


        movement = new Movement();

    }

    void Start()
    {
        


        if (player != null)
        {
            
            _currentState = player.stateIdle;

        }

        if (worldManager != null) {

            _currentState = worldManager.stateCountdown;

        }

        if (enemy != null) {

            _currentState = enemy.stateChase;
        }
        _currentState.EnterState(this);


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
