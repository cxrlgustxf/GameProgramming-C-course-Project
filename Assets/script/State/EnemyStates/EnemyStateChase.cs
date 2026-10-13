using UnityEngine;
using UnityEngine.EventSystems;

public class EnemyStateChase : IState
{
    Vector2 moveDirection;
    public void EnterState(StateMachine cxt) { }
    public void ExitState(StateMachine cxt) { }
    public void UpdateState(StateMachine cxt) 
    {
        if (cxt.enemy.MoveTarget)
        {
            Vector3 direction = (cxt.enemy.MoveTarget.position - cxt.enemy.transform.position).normalized;
            moveDirection = direction;

            cxt.enemy.rb.linearVelocity = new Vector2(moveDirection.x, moveDirection.y) * 2;
            //float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        }
    }
}
