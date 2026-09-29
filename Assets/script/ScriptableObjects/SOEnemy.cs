using UnityEngine;

[CreateAssetMenu(fileName = "SOEnemy", menuName = "Scriptable Objects/SOEnemy")]
public class SOEnemy : ScriptableObject
{

    public float SizeScale;

    public float Damage;

    public float AttackSpeed;

    public float Health;
    public enum type
    {
        CHASING,
        RANGED,
        MAGIC,

    }

}
