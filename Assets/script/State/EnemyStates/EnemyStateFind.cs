using UnityEngine;

public class EnemyStateFind : IState
{
    public void EnterState(StateMachine cxt)
    { 
        
    }
    public void ExitState(StateMachine cxt)
    {
    
    }
    public void UpdateState(StateMachine cxt)
    {
        if(cxt.enemy.Health == 0)
        {
            cxt.ChangeState(cxt.enemy.stateDead);
        }


        if( cxt.enemy.FindPlayer() != Vector2.zero)
        {
            cxt.enemy.MoveTarget = cxt.enemy.FindPlayer();
            cxt.ChangeState(cxt.enemy.stateChase);
        }

        

    }
}
