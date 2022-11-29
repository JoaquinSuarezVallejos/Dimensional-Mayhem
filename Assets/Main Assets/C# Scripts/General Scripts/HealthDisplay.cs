using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using EmeraldAI.Example;

public class HealthDisplay : MonoBehaviour
{
    int currentHealth;
    public int maxPlayerHealth = 180;
    public GameObject textMeshPro_HealthText, textMeshPro_HealthSprite;
    EmeraldAIPlayerHealth healthScript;
    TextMeshProUGUI HealthDisplayText, HealthSprite;

    void Start()
    {
        HealthDisplayText = textMeshPro_HealthText.GetComponent<TextMeshProUGUI>();
        HealthSprite = textMeshPro_HealthSprite.GetComponent<TextMeshProUGUI>();

        healthScript = GameObject.Find("PlayerController").GetComponent<EmeraldAIPlayerHealth>();
    }

    void Update()
    {
        currentHealth = healthScript.CurrentHealth;
        HealthDisplayText.text = currentHealth.ToString();

        if (currentHealth <= maxPlayerHealth && currentHealth >= 75)
        {
            HealthSprite.text = "<sprite name=\"Heart1\">";
        }

        else if (currentHealth <= 75 && currentHealth >= 50)
        {
            HealthSprite.text = "<sprite name=\"Heart2\">";
        }

        else if (currentHealth <= 50 && currentHealth >= 25)
        {
            HealthSprite.text = "<sprite name=\"Heart3\">";
        }

        else 
        {
            HealthSprite.text = "<sprite name=\"Heart4\">";
        }
    }
}
