using Unity.VisualScripting;
using UnityEngine;

public class StateCountdown : IState
{
    

    public float Timer;

    public void EnterState(StateMachine cxt)
    {
        Timer = 10f;
    }
    public void ExitState(StateMachine cxt)
    {
        
    }

    public void UpdateState(StateMachine cxt)
    {
        Timer -= Time.deltaTime;

        Mathf.Clamp(Timer, 0, 10);

        if(Timer == 0)
        {
            cxt.ChangeState(cxt.worldManager.stateWaveActive);
        }
    }
}
