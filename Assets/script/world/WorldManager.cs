using UnityEngine;

public class WorldManager : MonoBehaviour
{

    [SerializeField]private GameObject playerPrefab;
    [SerializeField]private GameObject[] EnemyPrefabs;
    private EnemySpawnManager spawnManager;

    void Start()
    {
        Instantiate(playerPrefab, new Vector2(0,0), Quaternion.identity);
        spawnManager = new EnemySpawnManager();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
