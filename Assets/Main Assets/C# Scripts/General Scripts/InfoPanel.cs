using EmeraldAI.Example;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InfoPanel : MonoBehaviour
{
    float currentHealth;
    EmeraldAIPlayerHealth healthScript;

    string currentTime;
    TimeElapsed timeScript;

    string currentLevel;

    Text panelText;

    // Start is called before the first frame update
    void Start()
    {
        healthScript = GameObject.Find("PlayerController").GetComponent<EmeraldAIPlayerHealth>();
        timeScript = GameObject.Find("TIME ELAPSED").GetComponent<TimeElapsed>();
        currentLevel = SceneManager.GetActiveScene().name;
        panelText = GameObject.Find("Panel Text").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        currentHealth = healthScript.CurrentHealth;
        currentTime = timeScript.currentTime;
        panelText.text = "Health: " + currentHealth.ToString() + "\n" + "Time elapsed: " + currentTime + "\n" + currentLevel;

    }
}
