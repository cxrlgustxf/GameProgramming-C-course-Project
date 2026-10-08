using UnityEngine;

[CreateAssetMenu(fileName = "SOItem", menuName = "Scriptable Objects/SOItem")]
public class SOItem : ScriptableObject
{

    public Sprite icon;

    public AnimationClip animation;
    public float Damage;

    public int Penetration;

    public float ProjectileRange;
    public int ProjectileAmount;

    public float AttackSpeed;

    public float AttackRate;
    public ItemType itemType;
}

public enum ItemType
{
    MELEE,
    RANGED,
    HEAL,


}