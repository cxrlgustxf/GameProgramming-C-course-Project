using UnityEngine;
using System;

public class EnemySpawnManager
{
    public EnemySO[] _object;


    public int wave = 1;

    public int CurrentAmountEnemies;

    public int MaxAmountEnemies;

    public int FraggedEnemies;

    public float EnemyHealthMultiplier = 1;

    public float EnemyDamageMultiplier = 1;

    

   
    public void IncreaseWave()
    {
        
        if(MaxAmountEnemies < 100)
        {
            MaxAmountEnemies += 5;
        }


        EnemyHealthMultiplier = wave * wave * 0.5f;

        wave += 1;
        FraggedEnemies = 0;
    }




    

}


public static class SpawnerEvents
{
    public static event Action<int> EnemiesFragged;

}