using System;
using UnityEngine;
using UnityEngine.UI;

public class InGameUI : MonoBehaviour
{

    [SerializeField] Image HealthBar;
    [SerializeField] Image EXPBar;
    void Awake()
    {
        
        EventsUI.OnHealthChanged += UpdateHealthBar;
        EventsUI.OnEXPGained += UpdateEXPBar;
    }


    
    void UpdateHealthBar(float newHP)
    {
        HealthBar.fillAmount = newHP / 100f;
    }



    void UpdateEXPBar(float Amount)
    {
        EXPBar.fillAmount = Amount / 100f;
    }
    void OnDestroy()
    {
        EventsUI.OnHealthChanged -= UpdateHealthBar;
        EventsUI.OnEXPGained -= UpdateEXPBar;
    }
}

public static class EventsUI
{

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

}

