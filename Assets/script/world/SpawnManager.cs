using UnityEngine;

public class SpawnManager
{


    public int MaxEnemies = 10;


    public float stats;


    public void WaveMultiplier(int waves) 
    {

        MaxEnemies += 5;
        MaxEnemies = Mathf.Clamp(MaxEnemies, 10, 100);
        


    }

}
