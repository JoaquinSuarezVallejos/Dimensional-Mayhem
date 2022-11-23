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
        int minutes = (int)timePassed / 60;
        int seconds = (int)timePassed % 60;
        if (minutes < 10 && seconds > 10)
        {
            currentTime = "0" + minutes + ":" + seconds;
        }
        if (seconds < 10 && minutes > 10)
        {
            currentTime = minutes + ":0" + seconds;
        }
        if (seconds < 10 && minutes < 10)
        {
            currentTime = "0" + minutes + ":0" + seconds;
        }
    }
}
