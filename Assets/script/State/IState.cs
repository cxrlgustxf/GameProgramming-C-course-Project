using UnityEngine;

public interface IState
{
    
    void EnterState(StateManager cxt) { }

    void ExitState(StateManager cxt) { }

    void UpdateState(StateManager cxt) { }



}
