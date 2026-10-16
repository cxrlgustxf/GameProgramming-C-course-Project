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
    public int PlayerLevel;

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
        NextLevelUp = 30;
        PlayerLevel = 1;

        EventsUI.HealthHasChanged(Health);
        EventsUI.EXPHasChanged(PlayerEXP);
       
    }


    public void HandleUpdates()
    {
        regenHealth(HealthRegen, Time.deltaTime);
        TickInvincibility();
        
    }


    void regenHealth(float regenAmount, float delta)
    {


        if (Health <= MaxHealth)
            {
            Health += regenAmount * delta;
            Mathf.Clamp(Health, 0, MaxHealth);
            EventsUI.HealthHasChanged(Health);
            }
        
    }

    public void GainEXP(float EXP)
    {

        
        
        PlayerEXP += EXP;

        if (PlayerEXP >= NextLevelUp)
        {
            
            float buffer = PlayerEXP - NextLevelUp; 

            NextLevelUp = NextLevelUp * 1.5f;
            PlayerLevel++;

            PlayerEXP = buffer;
            EventsUI.IncrementLevel(PlayerLevel);
            Debug.Log("Leveled up!! " + PlayerLevel);

        }

        float fillAmount = PlayerEXP / NextLevelUp;

        EventsUI.EXPHasChanged(fillAmount);
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
        InvincibilityTime = 0.5f;
        EventsUI.HealthHasChanged(Health);
        }

    }


    void TickInvincibility()
    {
        if (InvincibilityTime > 0)
        {
            InvincibilityTime -= Time.deltaTime;
            InvincibilityTime = Mathf.Clamp(InvincibilityTime, 0, 2);        
        }
        
    }



}
