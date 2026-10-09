using Unity.VisualScripting.Antlr3.Runtime.Misc;
using Unity.VisualScripting.FullSerializer;
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

    public float PlayerEXP;

    public float NextLevelUp;
    public float PlayerLevel;

    
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

    public void GainEXP(int EXP)
    {
        PlayerEXP += EXP;

        EventsUI.EXPHasChanged(EXP);
        if (PlayerEXP >= NextLevelUp)
        {
            NextLevelUp = NextLevelUp * 1.2f;

        }
    }



    public void LevelUp()
    {
        

    }

    public void Heal(float healAmount)
    {
        Health += healAmount;
        EventsUI.HealthHasChanged(Health);
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

    public void InitStats(float multiplier)
    {
        MaxHealth = 100 * multiplier;
        Health = MaxHealth * 0.5f;
        HealthRegen = 1f * multiplier;

        Speed = 5f * multiplier;

        MaxMana = 100 * multiplier;
        Mana = MaxMana * multiplier;
        ManaRegen = 0.3f * multiplier;
        PlayerEXP = 0f;

        EventsUI.HealthHasChanged(Health);
        EventsUI.EXPHasChanged(PlayerEXP);
    }
}
