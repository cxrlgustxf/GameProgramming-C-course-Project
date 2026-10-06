using System;
using Unity.VisualScripting;
using UnityEngine;

public class StateEnemySpawnIn : IState
{

    private float spawnInTimer = 3f;
    private float Opacity;
    public void EnterState(StateMachine cxt)
    {
        
    }
    public void ExitState(StateMachine cxt)
    {
        
    }
    public void UpdateState(StateMachine cxt)
    {
        spawnInTimer -= Time.deltaTime;
        Mathf.Clamp(spawnInTimer, 0, 3);

        Opacity = spawnInTimer / 100f;

        cxt.enemy.ActiveSprite.color = new Color(1f, 1f, 1f, Opacity);
        

    }
}
