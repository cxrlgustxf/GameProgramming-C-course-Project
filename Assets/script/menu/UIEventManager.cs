using System;
using UnityEngine;
using UnityEngine.UI;

public class InGameUI : MonoBehaviour
{

    [SerializeField] Image HealthBar;
    void Start()
    {
        EventsUI.OnHealthChanged += UpdateHealthBar;

    }

    // Update is called once per frame
    
    void UpdateHealthBar(float newHP)
    {
        HealthBar.fillAmount = newHP / 100f;
    }
}

public static class EventsUI
{

    public static event Action<float> OnHealthChanged;

    public static void HealthHasChanged(float newHPValue)
    {
        OnHealthChanged.Invoke(newHPValue);
    }

}

