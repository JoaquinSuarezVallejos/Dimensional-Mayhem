using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InfoManager : MonoBehaviour
{
    KillCounter killCounter;
    //[SerializeField] Text killedAmount;
    LevelDeath levelDeath;
    //[SerializeField] Text SceneDeathName;
    TimeElapsed timeElapsed;
    //[SerializeField] Text timePassed;
    GetDamage getDamage;
    //[SerializeField] Text damageAmount;
    TextMeshProUGUI killedAmountText, SceneDeathNameText, timePassedText, damageAmountText;
    public GameObject TMPro_killedAmount, TMPro_SceneDeathName, TMPro_timePassed, TMPro_damageAmount;

    void Start()
    {
        killedAmountText = TMPro_killedAmount.GetComponent<TextMeshProUGUI>();
        SceneDeathNameText = TMPro_SceneDeathName.GetComponent<TextMeshProUGUI>();
        timePassedText = TMPro_timePassed.GetComponent<TextMeshProUGUI>();
        damageAmountText = TMPro_damageAmount.GetComponent<TextMeshProUGUI>();

        killCounter = GameObject.Find("ENEMY KILLS COUNTER").GetComponent<KillCounter>();
        killedAmountText.text = "Enemies killed: " + killCounter.kills.ToString();
        levelDeath = GameObject.Find("LEVEL DEATH INFO").GetComponent<LevelDeath>();
        SceneDeathNameText.text = "Level reached: " + levelDeath.SceneName;
        timeElapsed = GameObject.Find("TIME ELAPSED").GetComponent<TimeElapsed>();
        timePassedText.text = "Time elapsed: " + timeElapsed.currentTime;
        getDamage = GameObject.Find("DAMAGE DONE COUNTER").GetComponent<GetDamage>();
        damageAmountText.text = "Damage dealt: " + getDamage.damageDone;
    }
}
