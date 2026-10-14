using UnityEngine;

public class StateWaveActive : IState
{


    float SpawnTimer;
    int MaxEnemies = 5;
    int Wave;

    float LowSpawnTime = 0.5f;
    float HighSpawnTime = 5;

    float EnemyStatsMultiplier;
    int SpawnedEnemies;
    public void EnterState(StateMachine cxt)
    {

        SpawnedEnemies = 0;
        if (Wave < 20)
        {
            MaxEnemies += 5;
            HighSpawnTime -= 0.05f;
            LowSpawnTime -= 0.05f;

        }
        EnemyStatsMultiplier = (float)Wave * 0.7f;
        SpawnTimer = Random.Range(1, 3);
    }
    public void ExitState(StateMachine cxt)
    {
        
    }
    public void UpdateState(StateMachine cxt)
    {
        SpawnTimer -= Time.deltaTime;
        SpawnTimer = Mathf.Clamp(SpawnTimer, 0, 3);

        if (SpawnTimer == 0f && SpawnedEnemies <= MaxEnemies)
        {

            
            
            SpawnTimer = Random.Range(1, 3);
            cxt.worldManager.SpawnEnemy(cxt.worldManager.EnemyPrefabs[0], EnemyStatsMultiplier);
            SpawnedEnemies++;
        }
    }
}
