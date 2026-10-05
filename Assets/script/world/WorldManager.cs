using System;
using UnityEngine;
public class WorldManager : MonoBehaviour
{

    [SerializeField] GameObject playerPrefab;
    [SerializeField] GameObject[] EnemyPrefabs;
    [SerializeField] GameObject EnemySpawner;

    [SerializeField] GameObject GameUI;
    private EnemySpawnManager spawnManager;


    void Start()
    {
        Instantiate(GameUI, Vector2.zero, Quaternion.identity);
        Instantiate(playerPrefab, Vector2.zero, Quaternion.identity);
        spawnManager = new EnemySpawnManager();


    }


    // Update is called once per frame
    void Update()
    {
        
    }

}


