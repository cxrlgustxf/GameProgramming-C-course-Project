using UnityEngine;

public abstract class StateMachine
{



    public abstract void UpdateStateManager(IState state);


    public abstract void ChangeState(IState newState);

    public virtual void FetchContext(Player cxt) { }
    public virtual void FetchContext(Enemy cxt) { }
    public virtual void FetchContext(WorldManager cxt) { }
}
