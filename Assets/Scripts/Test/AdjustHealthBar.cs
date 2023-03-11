using System;
using System.Collections;
using System.Collections.Generic;
using RPG.Combat;
using RPG.Core;
using UnityEngine;
using UnityEngine.UI;

public class AdjustHealthBar : MonoBehaviour
{
    [SerializeField] Health health;
    
    private Slider slider;
    
    private void Start()
    {
        slider = GetComponent<Slider>();
        Fighter.OnDamageTaken += AdjustSlider;
    }

    private void AdjustSlider()
    {
        slider.value = health.healthPoints;
    }
}
