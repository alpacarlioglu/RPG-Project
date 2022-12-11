using System;
using System.Collections;
using System.Collections.Generic;
using RPG.Core;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI deathText;
    
    private int _deaths = 0;

    private void Start()
    {
        Health.OnDeath += IncreaseDeathText;
    }
    
    private void IncreaseDeathText()
    {
        _deaths++;
        deathText.text = "Death: " + _deaths;
    }
}
