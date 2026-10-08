using Unity.VisualScripting;
using UnityEngine;

public class StateMove : IState
{

    public void EnterState(StateMachine cxt)
    {


    }
    public void ExitState(StateMachine cxt)
    {
        cxt.player.rb.linearVelocity = Vector2.zero;
    }
    public void UpdateState(StateMachine cxt) 
    {


        cxt.player.rb.linearVelocity = cxt.movement.GetMovement(cxt.player.input.MovementInput, cxt.player.stats.Speed);
        cxt.player.animations.SetWalkAnimation(cxt.player.input.MovementInput.x, cxt.player.input.MovementInput.y, cxt.player.input.IsMoving);

        if (!cxt.player.input.IsMoving)
        {
            cxt.ChangeState(cxt.player.stateIdle);

        }

    }
}
