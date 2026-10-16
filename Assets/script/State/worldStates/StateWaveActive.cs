using UnityEngine;

public class StateWaveActive : IState
{


    float SpawnTimer;
    int MaxEnemies = 5;
    int Wave = 1;

    float LowSpawnTime = 0.5f;
    float HighSpawnTime = 3f;

    float EnemyStatsMultiplier;
    int SpawnedEnemies;

  
    public void EnterState(StateMachine cxt)
    {

        EventsUI.IncrementWave(Wave);
        SpawnedEnemies = 0;
        if (Wave < 20)
        {
            MaxEnemies += 5;
            HighSpawnTime -= 0.05f;
            LowSpawnTime -= 0.05f;

        }
        EnemyStatsMultiplier = (float)Wave * 0.7f;
        SpawnTimer = Random.Range(LowSpawnTime, HighSpawnTime);
        EventsUI.EnemyAmount = MaxEnemies;
        
        EventsUI.EnemyHasBeenKilled(MaxEnemies);

    }
    public void ExitState(StateMachine cxt)
    {
        Wave++;
        
        
    }
    public void UpdateState(StateMachine cxt)
    {
        SpawnTimer -= Time.deltaTime;
        SpawnTimer = Mathf.Clamp(SpawnTimer, 0, HighSpawnTime);


        if (EventsUI.EnemyAmount == 0)
        {
            cxt.ChangeState(cxt.worldManager.stateCountdown);
        }


        if (SpawnTimer == 0f && SpawnedEnemies < MaxEnemies)
        {

            
            
            SpawnTimer = Random.Range(LowSpawnTime, LowSpawnTime);
            cxt.worldManager.SpawnEnemy(cxt.worldManager.EnemyPrefabs[0], EnemyStatsMultiplier);

            SpawnedEnemies++;

            Debug.Log("Spawned enemies: " + SpawnedEnemies.ToString() + " Max enemies: " + MaxEnemies.ToString());
        }

    }
}
