using Unity.VisualScripting;
using UnityEngine;

public class StateMove : IState
{

    public void EnterState(StateMachine cxt)
    {


    }
    public void ExitState(StateMachine cxt)
    {

    }
    public void UpdateState(StateMachine cxt) 
    {


        cxt.player.rb.linearVelocity = cxt.movement.GetMovement(cxt.player.input.MovementInput, 5f);
        cxt.player.animations.SetAnimation(cxt.player.input.MovementInput.x, cxt.player.input.MovementInput.x, cxt.player.input.IsMoving);

        if (!cxt.player.input.IsMoving)
        {
            cxt.ChangeState(cxt.stateIdle);

        }

    }
}
