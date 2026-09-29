using UnityEngine;

[CreateAssetMenu(fileName = "Projectile", menuName = "Scriptable Objects/EnemyType")]
public class Projectile : ScriptableObject
{

    public Sprite Icon;

    public float Damage;

    public float Speed;

    public float Range;

    public float TimeToLive;

    public Vector2 SpawnPoint;

    public float Scale;

    public AnimationClip Animation;

}
