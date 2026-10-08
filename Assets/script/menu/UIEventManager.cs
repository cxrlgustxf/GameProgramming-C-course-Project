using System;
using UnityEngine;
using UnityEngine.UI;

public class InGameUI : MonoBehaviour
{

    [SerializeField] Image HealthBar;
    void Awake()
    {
        EventsUI.OnHealthChanged += UpdateHealthBar;

    }


    
    void UpdateHealthBar(float newHP)
    {
        HealthBar.fillAmount = newHP / 100f;
    }

        void OnDestroy(){
            EventsUI.OnHealthChanged -= UpdateHealthBar;
        }
}

public static class EventsUI
{

    public static event Action<float> OnHealthChanged;
    public static event Action<int> OnEXPGained;

    public static void HealthHasChanged(float newHPValue)
    {
        OnHealthChanged.Invoke(newHPValue);
    }
    
    public static void EXPHasChanged(int GainedEXP)
    {
        OnEXPGained.Invoke(GainedEXP);
    }

}

