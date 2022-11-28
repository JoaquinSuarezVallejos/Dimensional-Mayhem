using EmeraldAI.Example;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class InfoPanel : MonoBehaviour
{
    float currentHealth;
    EmeraldAIPlayerHealth healthScript;
    string currentTime;
    TimeElapsed timeScript;
    string currentLevel;

    void Start()
    {
        healthScript = GameObject.Find("PlayerController").GetComponent<EmeraldAIPlayerHealth>();
        timeScript = GameObject.Find("TIME ELAPSED").GetComponent<TimeElapsed>();
        currentLevel = SceneManager.GetActiveScene().name;
        //panelText = GameObject.Find("Panel Text").GetComponent<Text>();
    }

    void Update()
    {
        currentHealth = healthScript.CurrentHealth;
        timeScript.GetCurrentTime();
        currentTime = timeScript.currentTime;
        //panelText.text = "Health: " + currentHealth.ToString() + "\n" + "Time elapsed: " + currentTime + "\n" + currentLevel;
        Debug.Log("Health: " + currentHealth.ToString() + "\n" + "Time elapsed: " + currentTime + "\n" + currentLevel);
    }
}
