using System;
using UnityEngine;
public class WorldManager : MonoBehaviour
{

    [SerializeField] GameObject playerPrefab;
    [SerializeField] GameObject[] EnemyPrefabs;
    [SerializeField] GameObject EnemySpawner;

    [SerializeField] GameObject GameUI;

    public StateCountdown stateCountdown;

    public StateWaveActive stateWaveActive;

    

    public float Countdown;

    void Awake()
    {
        stateCountdown = new StateCountdown();
        stateWaveActive = new StateWaveActive();

        Instantiate(GameUI, Vector2.zero, Quaternion.identity);
        Instantiate(playerPrefab, Vector2.zero, Quaternion.identity);
        Instantiate(EnemySpawner, Vector2.zero, Quaternion.identity);
    }
    void Start()
    {



    }


    // Update is called once per frame
    void Update()
    {
        
        
        
    }





}


