using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public List<SOItem> Weapon = new List<SOItem>();
    public Rigidbody2D rb;
    public Animations animations;
    public InputManager input;

    public CircleCollider2D attackArea;

    public float AttackCooldown;

    public PlayerStats stats;
    [SerializeField]public float StatMultiplier;

    public StateIdle stateIdle;
    public StateMove stateMove;

     
    
    void Awake()
    {
        animations = GetComponent<Animations>();
        input = GetComponent<InputManager>();
        rb = GetComponent<Rigidbody2D>();
        attackArea = GetComponent<CircleCollider2D>();

        stateIdle = new StateIdle();
        stateMove= new StateMove();

        stats = new PlayerStats();
        
        InitStats(StatMultiplier);
    }


    void Update()
    {
        
        stats.HandleUpdates();


        

    }



    private void InitStats(float multiplier)
    {
        stats.MaxHealth = 100 * multiplier;
        stats.Health = stats.MaxHealth * 0.5f;
        stats.HealthRegen = 1f * multiplier;

        stats.Speed = 5f * multiplier;

        stats.MaxMana = 100 * multiplier;
        stats.Mana = stats.MaxMana * multiplier;
        stats.ManaRegen = 0.3f * multiplier;


        
    }


}
