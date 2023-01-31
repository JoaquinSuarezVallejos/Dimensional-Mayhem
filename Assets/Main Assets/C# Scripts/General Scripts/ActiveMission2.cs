using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ActiveMission2 : MonoBehaviour
{
    int totalEnemies2;
    int enemiesLeft2;
    GameObject[] enemiesArray2;
    KillCounter playerKills2;
    public GameObject TMPro_MissionText1, TMPro_MissionText2, TMPro_Mission1Sprite, TMPro_Mission2Sprite;
    TextMeshProUGUI MissionDisplayText1, MissionDisplayText2;

    void Start()
    {
        MissionDisplayText1 = TMPro_MissionText1.GetComponent<TextMeshProUGUI>();
        MissionDisplayText2 = TMPro_MissionText2.GetComponent<TextMeshProUGUI>();

        playerKills2 = GameObject.Find("ENEMY KILLS COUNTER").GetComponent<KillCounter>();
        enemiesArray2 = GameObject.FindGameObjectsWithTag("Respawn");
        totalEnemies2 = enemiesArray2.Length;
    }

    void Update()
    {
        enemiesLeft2 = totalEnemies2 - playerKills2.kills + 14; 

        if (enemiesLeft2 == 0)
        {
            TMPro_MissionText1.SetActive(false);
            TMPro_MissionText2.SetActive(true);
            MissionDisplayText2.text = "Find\nthe time\nmachine";
            TMPro_Mission1Sprite.SetActive(false);
            TMPro_Mission2Sprite.SetActive(true);
        }

        else 
        {
            TMPro_MissionText1.SetActive(true);
            TMPro_MissionText2.SetActive(false);
            MissionDisplayText1.text = "Enemies\nleft: " + enemiesLeft2.ToString();       
            TMPro_Mission1Sprite.SetActive(true);
            TMPro_Mission2Sprite.SetActive(false);
        }
    }
}
