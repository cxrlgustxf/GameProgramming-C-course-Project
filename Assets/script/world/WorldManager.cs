using UnityEngine;

public class WorldManager : MonoBehaviour
{

    [SerializeField]private GameObject playerPrefab;


    void Start()
    {
        Instantiate(playerPrefab, new Vector2(0,0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
