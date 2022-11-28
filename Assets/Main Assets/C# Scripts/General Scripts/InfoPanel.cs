using EmeraldAI.Example;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InfoPanel : MonoBehaviour
{
    float currentHealth;
    EmeraldAIPlayerHealth healthScript;

    float currentTime;
    TimeElapsed timeScript;

    string currentLevel;


    // Start is called before the first frame update
    void Start()
    {
        healthScript = GameObject.Find("PlayerController").GetComponent<EmeraldAIPlayerHealth>();
        timeScript = GameObject.Find("TIME ELAPSED").GetComponent<TimeElapsed>();
        currentLevel = SceneManager.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
