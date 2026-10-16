using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerStats
{

    public float Speed;

    public float Health;

    public float MaxHealth;

    public float HealthRegen;


    public float InvincibilityTime;

    public float PlayerEXP;

    public float NextLevelUp;
    public int PlayerLevel;

        public void InitStats(float multiplier)
    {
        MaxHealth = 100 * multiplier;
        Health = MaxHealth * 0.5f;
        HealthRegen = 1f * multiplier;

        Speed = 5f * multiplier;


        PlayerEXP = 0f;
        NextLevelUp = 30;
        PlayerLevel = 0;

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

            NextLevelUp = NextLevelUp * 1.1f;
            PlayerLevel++;

            PlayerEXP = buffer;
            EventsUI.IncrementLevel(PlayerLevel);
            SceneManager.LoadScene("LevelUpScene", LoadSceneMode.Additive);

        }

        float fillAmount = PlayerEXP / NextLevelUp;

        EventsUI.EXPHasChanged(fillAmount);
    }

    public void OnUpgrade(int Leveldown)
    {
        PlayerLevel -= Leveldown;
        EventsUI.IncrementLevel(PlayerLevel);
        SceneManager.UnloadSceneAsync("LevelUpScene");
        Time.timeScale = 1f;

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

    if (Health == 0) {
            SceneManager.LoadScene("DeathScene", LoadSceneMode.Additive);
            Time.timeScale = 0.0f;
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
