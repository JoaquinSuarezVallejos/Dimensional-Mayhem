using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeElapsed : MonoBehaviour
{
    public float timePassed;
    public string currentTime;
    public static TimeElapsed Instance;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(Instance.gameObject);
        }
    }

    void Update()
    {
        timePassed += Time.deltaTime;
    }

    public void GetCurrentTime()
    {
        float minutes = timePassed / 60;
        float seconds = timePassed % 60;
        currentTime = minutes + ":" + seconds;   
    }
}
