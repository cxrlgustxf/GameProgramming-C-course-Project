using UnityEngine;

public class Enemy: MonoBehaviour
{


    [SerializeField]public EnemySO _object;

    public float Health;

    public float Speed;

    public Vector3 Scale;

    public float AttackSpeed;

    public float ProjectileSpeed;

    public float AttackRange;
    public float AttackDamage;

    public Vector2 Target;







    public AttackType attackType;
    
    void Awake()
    {
        Health = _object.Health;
        Speed = _object.Speed;
        Scale = _object.Scale;
        AttackDamage = _object.AttackDamage;
        AttackSpeed = _object.AttackSpeed;
        ProjectileSpeed = _object.ProjectileSpeed;
        AttackRange = _object.AttackRange;
        attackType = _object.attackType;


    }

}
