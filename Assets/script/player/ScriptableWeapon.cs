using UnityEngine;

[CreateAssetMenu(fileName = "PlayerWeapons", menuName = "Scriptable Objects/PlayerWeapons")]
public class PlayerWeapons : ScriptableObject
{
    public float AttackDamage;

    public float AttackRange;

    public float AttackRate;

    public float AttackSpeed;

    public int PenetrationForce;


}
