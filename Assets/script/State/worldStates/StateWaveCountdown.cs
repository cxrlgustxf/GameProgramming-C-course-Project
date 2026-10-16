using UnityEngine;

public class StateCountdown : IState
{
    

    public void EnterState(StateMachine cxt)
    {
        cxt.worldManager.Countdown = 5f;
        EventsUI.ToggleVisibilityForCounter(true);
    }
    public void ExitState(StateMachine cxt)
    {
        EventsUI.ToggleVisibilityForCounter(false);
    }

    public void UpdateState(StateMachine cxt)
    {
      if  (cxt.worldManager.Countdown >= 0) 
        {
            
            cxt.worldManager.Countdown -= Time.deltaTime;
        }


        cxt.worldManager.Countdown = Mathf.Clamp(cxt.worldManager.Countdown, 0f, 10f);
        EventsUI.CountdownActive(Mathf.RoundToInt(cxt.worldManager.Countdown));
        if (cxt.worldManager.Countdown == 0f)
        {
            cxt.ChangeState(cxt.worldManager.stateWaveActive);
        }
    }
}
