using UnityEngine;
public class Enemy: MonoBehaviour
{


    [SerializeField]public EnemySO _object;


    public Rigidbody2D rb;
    public float Health;

    public float Speed;

    public Vector3 Scale;

    public float AttackSpeed;

    public float ProjectileSpeed;

    public float AttackRange;
    public float AttackDamage;

    public Transform MoveTarget;

    public Vector2 ShootTarget;

    public float EXPReward;
    
    public CircleCollider2D PlayerScan;

    public SpriteRenderer ActiveSprite;


    public AttackType attackType;


    public EnemyStateChase stateChase;
    public EnemyStateDead stateDead;


    
    void Awake()
    {

        ActiveSprite = GetComponent<SpriteRenderer>();
        PlayerScan = GetComponent<CircleCollider2D>();
        rb = GetComponent<Rigidbody2D>();
        Health = _object.Health;
        Speed = _object.Speed;
        Scale = _object.Scale;
        
        AttackDamage = _object.AttackDamage;
        AttackSpeed = _object.AttackSpeed;
        ProjectileSpeed = _object.ProjectileSpeed;
        AttackRange = _object.AttackRange;
        attackType = _object.attackType;
        EXPReward = _object.EXPReward;
        stateChase = new EnemyStateChase();
        stateDead = new EnemyStateDead();

        
    }

    public void StatMultiply(float multiplier)
    {
        Speed = Speed * multiplier;
        Speed = Mathf.Clamp(Speed, 0, 20);

        Health = Health * multiplier;
    }
    
    void Start()
    {
        MoveTarget = GameObject.FindWithTag("Player").transform;
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && attackType == AttackType.MELEE)
        {
            var player = collision.gameObject.GetComponent<Player>();
            player.stats.TakeDamage(AttackDamage);
            
        }
    }

    public Vector2 FindPlayer()
    {

        float castRadius = 100.0f;
        float castDistance = 5.0f;
        LayerMask detectionLayers = -1;
        Vector2 origin = transform.position;
        Vector2 direction = transform.right;

        RaycastHit2D hit = Physics2D.CircleCast(
        origin,
        castRadius,
        direction,
        castDistance,
        detectionLayers
        
        );

        if (hit.collider == hit.collider.gameObject.CompareTag("Player")) {
            Vector2 playerPos = hit.collider.gameObject.transform.position;
            return playerPos;
        }
        return Vector2.zero;

    }


    public void TakeDamage(float amount, Player _player)
    {
        Health -= amount;
        Health = Mathf.Clamp(Health,0 , 1000);

        if(Health == 0)
        {

            EventsUI.EnemyAmount--;
            EventsUI.IncreaseScore(1);
            EventsUI.EnemyHasBeenKilled(EventsUI.EnemyAmount);
            _player.stats.GainEXP(EXPReward);
            Destroy(gameObject);
        }
    }

}
