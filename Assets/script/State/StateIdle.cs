using UnityEngine;

public class StateIdle : IState
{

    public void EnterState(StateMachine cxt)
    {
        
        cxt.player.animations.SetAnimation(cxt.player.animations.LastX, cxt.player.animations.LastY, cxt.player.input.IsMoving);
    }
    public void ExitState(StateMachine cxt)
    {

    }
    public void UpdateState(StateMachine cxt)
    {


        if (cxt.player.input.IsMoving)
        {
            cxt.ChangeState(cxt.stateMove);
        }
    }
}
