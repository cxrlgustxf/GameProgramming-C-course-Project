using UnityEngine;

public class Weapon : MonoBehaviour
{

    [SerializeField] Player player;    
    [SerializeField] SOItem[] Weapons;

    public GameObject ProjectilePrefab;

    public Sprite[] ProjectileSprites;

    public float CooldownDuration;
    float CurrentCooldown;



    public float Damage;
    public int Penetration;

    public float Range;

    public int ProjectileAmount;

    public float AttackSpeed;

    public float AttackRate;

    public int CurrentWeapon;

    public Sprite icon;


    void Awake()
    {
        
        CurrentCooldown = 0f;
        CurrentWeapon = 0;
        InitWeapon();
    }



    public void InitWeapon()
    {
        Damage = Weapons[CurrentWeapon].Damage;
        Penetration = Weapons[CurrentWeapon].Penetration;
        Range = Weapons[CurrentWeapon].ProjectileRange;
        ProjectileAmount = Weapons[CurrentWeapon].ProjectileAmount;
        AttackSpeed = Weapons[CurrentWeapon].AttackSpeed;
        AttackRate = Weapons[CurrentWeapon].AttackRate;
        icon = Weapons[CurrentWeapon].icon;
    }


    void Update()
    {
        if(CurrentCooldown > 0)
        {
            CurrentCooldown -= Time.deltaTime;
            CurrentCooldown = Mathf.Clamp(CurrentCooldown, 0, 100);

        }
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && CurrentCooldown <= 0)
        {
            
            var enemy = collision.gameObject.GetComponent<Enemy>();

            GameObject SpawnedProjectile = Instantiate(ProjectilePrefab, transform.position, Quaternion.identity);

            Projectile projectileStats = SpawnedProjectile.GetComponent<Projectile>();

           

            Vector3 projectileDirection = (enemy.transform.position - transform.position).normalized;

            projectileStats.Init(Damage, AttackSpeed, Range, projectileDirection, Penetration, icon, player);
            CurrentCooldown = Weapons[CurrentWeapon].AttackRate;
            CurrentCooldown = Mathf.Clamp(CurrentCooldown, 0.05f, 3);
            

        }
    }
}
