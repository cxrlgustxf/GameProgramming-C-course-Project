using UnityEngine;

public interface IState
{
    
    void EnterState(StateMachine cxt) { }

    void ExitState(StateMachine cxt) { }

    void UpdateState(StateMachine cxt) { }



}
