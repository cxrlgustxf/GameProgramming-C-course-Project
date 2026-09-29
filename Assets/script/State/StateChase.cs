using Unity.VisualScripting;
using UnityEngine;

public class StateChase : IState
{
    
    void EnterState(StateManager cxt)
    {
    
    }
    void ExitState(StateManager cxt)
    {

    }
    void UpdateState(StateManager cxt) 
    {
        cxt.rb.linearVelocity = cxt.movement.GetMovement(cxt.input.MovementInput, 5f);
        cxt.animations.SetAnimation(cxt.input.MovementInput.x, cxt.input.MovementInput.y);
    }
}
