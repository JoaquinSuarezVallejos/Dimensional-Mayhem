using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoManager : MonoBehaviour
{
    KillCounter killCounter;
    [SerializeField] Text killedAmount;
    LevelDeath levelDeath;
    [SerializeField] Text SceneDeathName;
    TimeElapsed timeElapsed;
    [SerializeField] Text timePassed;

    // Start is called before the first frame update
    void Start()
    {
        killCounter = GameObject.Find("ENEMY KILLS COUNTER").GetComponent<KillCounter>();
        killedAmount.text = "You Killed " + killCounter.kills.ToString() + " enemies!";
        levelDeath = GameObject.Find("LEVEL DEATH INFO").GetComponent<LevelDeath>();
        SceneDeathName.text = "You reached " + levelDeath.SceneName;
        timeElapsed = GameObject.Find("TIME ELAPSED").GetComponent<TimeElapsed>();
        timePassed.text = "Time Elapsed " + timeElapsed.currentTime;
    }
}
