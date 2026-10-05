using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows;

public class Player : MonoBehaviour
{


    public Rigidbody2D rb;
    public Animations animations;
    public InputManager input;

    public CircleCollider2D attackArea;

    public float AttackCooldown;

    public PlayerStats stats;
    [SerializeField]public float StatMultiplier;
    void Start()
    {
        animations = GetComponent<Animations>();
        input = GetComponent<InputManager>();
        rb = GetComponent<Rigidbody2D>();
        attackArea = GetComponent<CircleCollider2D>();


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
