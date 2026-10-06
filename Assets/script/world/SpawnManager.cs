using UnityEngine;
using System;
using JetBrains.Annotations;

public class EnemySpawnManager
{
    public EnemySO[] _object;

   [SerializeField] GameObject[] Types;
    public int wave = 1;

    public int CurrentAmountEnemies;

    public int MaxAmountEnemies;

    public int FraggedEnemies;

    public int SpawnedEnemies;
    public float EnemyHealthMultiplier = 1;

    public float EnemyDamageMultiplier = 1;

    public float WaveCountdown;
    
    

    public void Init()
    {
        WaveCountdown = 10f;
        MaxAmountEnemies = 10;
        SpawnerEvents.EnemiesFragged += IncrementEnemies;
    }
    void IncrementEnemies()
    {
        FraggedEnemies++;


        if (FraggedEnemies >= MaxAmountEnemies) IncreaseWave();
    }
   
    public void IncreaseWave()
    {
        
        if(MaxAmountEnemies < 100)
        {
            MaxAmountEnemies += 5;
        }


        EnemyHealthMultiplier = wave * wave * 0.5f;

        wave++;
        SpawnedEnemies = 0;
        FraggedEnemies = 0;
    }




    

}



public static class SpawnerEvents
{
    public static event Action EnemiesFragged;



    public static void OnEnemyFragged(){

        EnemiesFragged.Invoke();

    }
    

}