using UnityEngine;

public enum AttackType
{
    RANGED,
    MAGIC,
    MELEE,
}

[CreateAssetMenu(fileName = "EnemySO", menuName = "Scriptable Objects/EnemySO")]
public class EnemySO : ScriptableObject
{

    public float Health;

    public float Speed;

    public Vector3 Scale;

    public float AttackSpeed;
    public float ProjectileSpeed;
    public float AttackRange;
    public float AttackDamage;

    public float EXPReward;

    public AttackType attackType;
    
}
