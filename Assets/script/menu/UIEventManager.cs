using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InGameUI : MonoBehaviour
{

    [SerializeField] Image HealthBar;
    [SerializeField] Image EXPBar;
    [SerializeField] TextMeshProUGUI CountdownUI;
    void Awake()
    {
        
        EventsUI.OnHealthChanged += UpdateHealthBar;
        EventsUI.OnEXPGained += UpdateEXPBar;
        EventsUI.OnCountdownActive += UpdateCountdown;
        EventsUI.OnToggleCounter += SetCountdownVisibility;
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
        EXPBar.fillAmount = Amount / 100f;
    }
    void OnDestroy()
    {
        EventsUI.OnHealthChanged -= UpdateHealthBar;
        EventsUI.OnEXPGained -= UpdateEXPBar;
        EventsUI.OnCountdownActive -= UpdateCountdown;
        EventsUI.OnToggleCounter -= SetCountdownVisibility;
    }
}

public static class EventsUI
{

    public static event Action<bool> OnToggleCounter;
    public static event Action<float> OnCountdownActive;
    public static event Action<float> OnHealthChanged;
    public static event Action<float> OnEXPGained;

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

}

