using System;
using TMPro;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.UI;

public class InGameUI : MonoBehaviour
{

    [SerializeField] Image HealthBar;
    [SerializeField] Image EXPBar;
    [SerializeField] TextMeshProUGUI CountdownUI;

    [SerializeField] TextMeshProUGUI RemainingEnemies;

    [SerializeField] TextMeshProUGUI WaveText;

    void Awake()
    {
        
        EventsUI.OnHealthChanged += UpdateHealthBar;
        EventsUI.OnEXPGained += UpdateEXPBar;
        EventsUI.OnCountdownActive += UpdateCountdown;
        EventsUI.OnToggleCounter += SetCountdownVisibility;
        EventsUI.OnEnemyKilled += UpdateEnemiesRemaining;
        EventsUI.OnWaveIncrease += UpdateWave;
    }


    
    void UpdateHealthBar(float newHP)
    {
        HealthBar.fillAmount = newHP / 100f;
    }


    void UpdateCountdown(float TimeLeft)
    {
        CountdownUI.text = TimeLeft.ToString();
    }

    void SetCountdownVisibility(bool visible) 
    
    {
        CountdownUI.gameObject.SetActive(visible);
    }
    void UpdateEXPBar(float Amount)
    {

        EventsUI.CurrentEXP += Amount;
        EXPBar.fillAmount = EventsUI.CurrentEXP / 100f;
    }

    void UpdateEnemiesRemaining(int Amount) {
        
        RemainingEnemies.text = Amount.ToString();

    }

    void UpdateWave(int newWave)
    {
        WaveText.text = newWave.ToString();
        Debug.Log("Wave Incremented, new wave: " + newWave);
    }


    void IncreaseScore(int Score)
    {
        
    }



    void IncreaseLevel(int Level)
    {
        
    }

    void OnDestroy()
    {
        EventsUI.OnHealthChanged -= UpdateHealthBar;
        EventsUI.OnEXPGained -= UpdateEXPBar;
        EventsUI.OnCountdownActive -= UpdateCountdown;
        EventsUI.OnToggleCounter -= SetCountdownVisibility;
        EventsUI.OnEnemyKilled -= UpdateEnemiesRemaining;
        EventsUI.OnWaveIncrease -= UpdateWave;
        
    }


}

public static class EventsUI
{

    public static int EnemyAmount;

    public static float CurrentEXP;
    public static int Score;
    public static event Action<bool> OnToggleCounter;
    public static event Action<float> OnCountdownActive;
    public static event Action<float> OnHealthChanged;
    public static event Action<float> OnEXPGained;

    public static event Action<int> OnWaveIncrease;

    public static event Action<int> OnEnemyKilled;

    public static event Action<bool> OnGameReset;

    public static void HealthHasChanged(float newHPValue)
    {
        OnHealthChanged?.Invoke(newHPValue);
    }
    
    public static void EXPHasChanged(float GainedXP)
    {
        OnEXPGained?.Invoke(GainedXP);
    }

    public static void CountdownActive(float TimeLeft)
    {
        OnCountdownActive?.Invoke(TimeLeft);
    }

    public static void ToggleVisibilityForCounter(bool visible)
    {
        OnToggleCounter?.Invoke(visible);
    }

    public static void EnemyHasBeenKilled(int amount)
    {
        OnEnemyKilled.Invoke(amount);
    }
    
    
    public static void GameHasReset(bool resetGame)
    {
        OnGameReset.Invoke(resetGame);
    }

    public static void IncrementWave(int newWave)
    {
        OnWaveIncrease.Invoke(newWave);
    }

}

