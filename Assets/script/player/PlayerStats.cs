using UnityEngine;
using UnityEngine.UI;
public class PlayerStats
{

    public float Speed;

    public float Health;

    public float MaxHealth;

    public float HealthRegen;

    public float Mana;

    public float MaxMana;

    public float ManaRegen;

    public float InvincibilityTime;

    public Image HealthBar;


    public void HandleUpdates()
    {
        regenHealth(HealthRegen, Time.deltaTime);
        TickInvincibility();
    }


    void regenHealth(float regenAmount, float delta)
    {


        if (Health < MaxHealth)
            {
            Health += regenAmount * delta;
            Mathf.Clamp(Health, 0, MaxHealth);
            EventsUI.HealthHasChanged(Health);
            }
        
    }


    public void TakeDamage(float damageAmount)
    {

    if(InvincibilityTime == 0) 
        {
        Health -= damageAmount;
        Health = Mathf.Clamp(Health, 0, MaxHealth);
        InvincibilityTime = 0.4f;
        EventsUI.HealthHasChanged(Health);
        }

    }


    void TickInvincibility()
    {
        if (InvincibilityTime > 0)
        {
            InvincibilityTime -= Time.deltaTime;
            Mathf.Clamp(InvincibilityTime, 0, 2);        
        }
        
    }
    
}
