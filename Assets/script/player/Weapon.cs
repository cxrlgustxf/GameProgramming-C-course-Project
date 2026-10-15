
using UnityEngine;
using System.Collections.Generic;


public class Weapon : MonoBehaviour
{


    [SerializeField] SOItem[] Weapons;

    public GameObject ProjectilePrefab;

    public Sprite[] ProjectileSprites;

    public float CooldownDuration;
    float CurrentCooldown;

    void Awake()
    {
        CurrentCooldown = 0f;
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

            Debug.Log("Why isnt it spawning??");

            Vector3 projectileDirection = (enemy.transform.position - transform.position).normalized;

            projectileStats.Init(Weapons[0].Damage, Weapons[0].AttackSpeed, Weapons[0].ProjectileRange, projectileDirection, Weapons[0].Penetration, Weapons[0].icon);
            CurrentCooldown = Weapons[0].AttackRate;
            
            

        }
    }
}
