using UnityEngine;

public class PlayerStateMachine : StateMachine
{


    public IState _currentState;
 

    public override void UpdateStateManager(IState _currentState)
    {
        throw new System.NotImplementedException();
    }

    public override void ChangeState(IState newState)
    {
        throw new System.NotImplementedException();
    }

    public override void FetchContext(Player player)
    {

        throw new System.NotImplementedException();
    }
}
