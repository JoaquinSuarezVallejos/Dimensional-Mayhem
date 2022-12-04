using EmeraldAI.Example;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class InfoPanel : MonoBehaviour
{
    #region Scripts
    TimeElapsed timeScript;
    EmeraldAIPlayerHealth healthScript;
    GameObject[] enemiesArray;
    KillCounter playerKills;
    #endregion
    
    #region Info
    float currentHealth;
    string currentTime;
    string currentLevel;
    int enemiesLeft;
    int totalEnemies;
    #endregion

    #region Texts
    [SerializeField] TextMeshProUGUI healthText;
    [SerializeField] TextMeshProUGUI timeText;
    [SerializeField] TextMeshProUGUI enemiesText;
    [SerializeField] TextMeshProUGUI levelText;
    #endregion

    void Start()
    {
        healthScript = GameObject.Find("PlayerController").GetComponent<EmeraldAIPlayerHealth>();
        timeScript = GameObject.Find("TIME ELAPSED").GetComponent<TimeElapsed>();
        currentLevel = SceneManager.GetActiveScene().name;
        playerKills = GameObject.Find("ENEMY KILLS COUNTER").GetComponent<KillCounter>();
        enemiesArray = GameObject.FindGameObjectsWithTag("Respawn");

        healthText = GameObject.Find("Health (TMP)").GetComponent<TextMeshProUGUI>();
        timeText = GameObject.Find("Clock (TMP)").GetComponent<TextMeshProUGUI>();
        enemiesText = GameObject.Find("Enemies (TMP)").GetComponent<TextMeshProUGUI>();
        levelText = GameObject.Find("Level (TMP)").GetComponent<TextMeshProUGUI>();

        totalEnemies = enemiesArray.Length;
    }

    void Update()
    {
        enemiesLeft = totalEnemies - playerKills.kills;
        currentHealth = healthScript.CurrentHealth;
        timeScript.GetCurrentTime();
        currentTime = timeScript.currentTime;
        healthText.text = "<sprite index= 0> " + currentHealth.ToString();
        timeText.text = "<sprite index= 0> " + currentTime;
        enemiesText.text = "<sprite index= 0> " + enemiesLeft.ToString();
        levelText.text = "<sprite index= 0> " + currentLevel;
    }
}
