using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using EmeraldAI.Example;

public class HealthDisplay : MonoBehaviour
{
    int currentHealth;
    public GameObject textMeshPro_HealthText;
    EmeraldAIPlayerHealth healthScript;
    TextMeshProUGUI HealthDisplayText;


    void Start()
    {
        HealthDisplayText = textMeshPro_HealthText.GetComponent<TextMeshProUGUI>();
        healthScript = GameObject.Find("PlayerController").GetComponent<EmeraldAIPlayerHealth>();
    }

    void Update()
    {
        currentHealth = healthScript.CurrentHealth;
        HealthDisplayText.text = currentHealth.ToString();
    }
}
