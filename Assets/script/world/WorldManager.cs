using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class WorldManager : MonoBehaviour
{

    [SerializeField] GameObject playerPrefab;
    [SerializeField] public GameObject[] EnemyPrefabs;


    [SerializeField] GameObject GameUI;

    public StateCountdown stateCountdown;

    public StateWaveActive stateWaveActive;

    public GameObject player;

    public float Countdown;

    public int Wave;


    void Awake()
    {
        stateCountdown = new StateCountdown();
        stateWaveActive = new StateWaveActive();

        Instantiate(GameUI, Vector2.zero, Quaternion.identity);
        Instantiate(playerPrefab, Vector2.zero, Quaternion.identity);

    }
    void Start()
    {
        player = GameObject.FindWithTag("Player");


    }


    // Update is called once per frame
    void Update()
    {
        
        
        
    }

    public void SpawnEnemy(GameObject enemy, float StatMultiplier)
    {

        Vector3 direction = new Vector3(Random.Range(-1, 1),  Random.Range(-1, 1), 0);
        direction = direction * 10;
        if (direction == Vector3.zero) { return; }
        Vector3 FinalSpawnpoint = (player.transform.position + direction);


        Instantiate(enemy, FinalSpawnpoint ,Quaternion.identity);
    }



}


