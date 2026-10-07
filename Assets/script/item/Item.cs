using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{


    public SOItem item;
    public SpriteRenderer _icon;

    public AnimationClip _animation;
    public float _Damage;

    public int _Penetration;

    public float _ProjectileRange;
    public int _ProjectileAmount;

    public float _AttackSpeed;

    public float _AttackRate;
    void Start()
    {
        
    }

    void Awake()
    {
        _icon = GetComponent<SpriteRenderer>();
        _icon.sprite = item.icon;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            var player = collision.gameObject.GetComponent<Player>();
            player.Weapon.Add(item);
            Destroy(gameObject);

        };

        Debug.Log("Hit");

        
    }
}
