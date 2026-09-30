using Unity.VisualScripting;
using UnityEngine;

public class StateChase : IState
{

    public void EnterState(StateMachine cxt)
    {
    
    }
    public void ExitState(StateMachine cxt)
    {

    }
    public void UpdateState(StateMachine cxt) 
    {
        cxt.rb.linearVelocity = cxt.movement.GetMovement(cxt.input.MovementInput, 5f);
        cxt.animations.SetAnimation(cxt.input.MovementInput.x, cxt.input.MovementInput.y);
    }
}
