using System;
using UnityEngine;

public class EnemySpawner : MonoBehaviour

{
 
    



    public void SpawnEnemy(GameObject type)
    {

        Instantiate(type, Vector2.zero, Quaternion.identity);

    }


}
