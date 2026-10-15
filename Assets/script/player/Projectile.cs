using UnityEngine;

public class Projectile : MonoBehaviour
{


    public float Damage;

    public float Speed;

    public float Range;

    public Vector2 Direction;

    public int Penetration;

    public SpriteRenderer sprite;
    public Rigidbody2D rb;

    private void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, Range);
    }
    public void Init(float damage, float speed, float range, Vector3 direction, int penetration, Sprite ProjectileSprite) 
    {
        
        Damage = damage;
        Speed = speed;
        Range = range;
        Direction = direction;
        Penetration = penetration;
        sprite.sprite = ProjectileSprite;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(0, 0, angle);
    }


    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = Direction * Time.deltaTime * Speed;
        Range -= Time.deltaTime;

            

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            var enemy = collision.gameObject.GetComponent<Enemy>();

            enemy.TakeDamage(Damage);
            Penetration -= 1;

            if(Penetration == 0)
            {
                Destroy(gameObject);
            }

            
        }
    }

}
