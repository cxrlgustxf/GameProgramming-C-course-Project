using UnityEngine;

public class GroundItem : MonoBehaviour
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

        _Damage = item.Damage;
        _icon.sprite = item.icon;


    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            var player = collision.gameObject.GetComponent<Player>();

            switch(item.itemType){

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
