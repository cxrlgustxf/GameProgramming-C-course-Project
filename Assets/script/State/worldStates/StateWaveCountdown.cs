using Unity.VisualScripting;
using UnityEngine;

public class StateCountdown : IState
{
    

    public void EnterState(StateMachine cxt)
    {
        cxt.worldManager.Countdown = 10f;
    }
    public void ExitState(StateMachine cxt)
    {
        
    }

    public void UpdateState(StateMachine cxt)
    {
      if  (cxt.worldManager.Countdown >= 0) 
        {
            cxt.worldManager.Countdown -= Time.deltaTime;
        }


        cxt.worldManager.Countdown = Mathf.Clamp(cxt.worldManager.Countdown, 0f, 10f);

        if (cxt.worldManager.Countdown == 0f)
        {
            cxt.ChangeState(cxt.worldManager.stateWaveActive);
        }
    }
}
