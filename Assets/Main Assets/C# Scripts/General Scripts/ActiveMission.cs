using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ActiveMission : MonoBehaviour
{
    int totalEnemies;
    int enemiesLeft;
    int extraEnemiesLeft;
    GameObject[] enemiesArray;
    KillCounter playerKills;
    public GameObject TMPro_MissionText1, TMPro_MissionText2, TMPro_Mission1Sprite, TMPro_Mission2Sprite;
    TextMeshProUGUI MissionDisplayText1, MissionDisplayText2;

    void Start()
    {
        MissionDisplayText1 = TMPro_MissionText1.GetComponent<TextMeshProUGUI>();
        MissionDisplayText2 = TMPro_MissionText2.GetComponent<TextMeshProUGUI>();

        playerKills = GameObject.Find("ENEMY KILLS COUNTER").GetComponent<KillCounter>();
        enemiesArray = GameObject.FindGameObjectsWithTag("Respawn");
        totalEnemies = enemiesArray.Length;
    }

    void Update()
    {
        extraEnemiesLeft = 4;
        enemiesLeft = totalEnemies - playerKills.kills + extraEnemiesLeft; 

        if (enemiesLeft == 0)
        {
            TMPro_MissionText1.SetActive(false);
            TMPro_MissionText2.SetActive(true);
            MissionDisplayText2.text = "Find\nthe\ncrystal";
            TMPro_Mission1Sprite.SetActive(false);
            TMPro_Mission2Sprite.SetActive(true);
        }

        else 
        {
            TMPro_MissionText1.SetActive(true);
            TMPro_MissionText2.SetActive(false);
            MissionDisplayText1.text = "Enemies\nleft: " + enemiesLeft.ToString();       
            TMPro_Mission1Sprite.SetActive(true);
            TMPro_Mission2Sprite.SetActive(false);
        }
    }
}
