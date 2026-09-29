using NUnit.Framework;
using System;
using UnityEngine;

public class EnemySpawnSystem : MonoBehaviour
{
    private int _currentWave;
    private int _currentEnemyCount;

    private int _maxEnemyCount;
    private float _waveCountdown;

    [SerializeField] GameObject[] enemies;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

}
