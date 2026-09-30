using Unity.VisualScripting;
using UnityEngine;

public class StateChase : IState
{

    public void EnterState(StateManager cxt)
    {
    
    }
    public void ExitState(StateManager cxt)
    {

    }
    public void UpdateState(StateManager cxt) 
    {
        cxt.rb.linearVelocity = cxt.movement.GetMovement(cxt.input.MovementInput, 5f);
        cxt.animations.SetAnimation(cxt.input.MovementInput.x, cxt.input.MovementInput.y);
    }
}
