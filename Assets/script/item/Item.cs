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

        _Damage = item.Damage;
        _Penetration = item.Penetration;
        _ProjectileRange = item.ProjectileRange;
        _ProjectileAmount = item.ProjectileAmount;
        _AttackSpeed = item.AttackSpeed;
        _AttackRate = item.AttackRate;
        _animation = item.animation;



        _icon = GetComponent<SpriteRenderer>();


        _icon.sprite = item.icon;


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            var player = collision.gameObject.GetComponent<Player>();

            switch(item.itemType){

                case ItemType.MELEE:
                    player.Weapon.Add(item);

                    Destroy(gameObject);

                    break;

                case ItemType.RANGED:
                    player.Weapon.Add(item);

                    Destroy(gameObject);

                    break;


                case ItemType.HEAL:

                    player.stats.Heal(_Damage);
                    Destroy(gameObject);
                    break;

                default:
                    Debug.Log("NO ITEM TYPE FOUND");
                    Destroy(gameObject);
                    break;
            }
                
 
            
            
            

        };

        

        
    }
}
