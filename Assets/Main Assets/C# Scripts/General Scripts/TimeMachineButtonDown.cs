using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeMachineButtonDown : MonoBehaviour
{
    public GameObject electricityEffect, finalBoss, wallFinalBoss1, wallFinalBoss2, missionCanvas;
    public AudioSource finalBossMusic, theVillageMusic;

    public void buttonPressed()
    {
        electricityEffect.SetActive(true);
        finalBoss.SetActive(true);
        wallFinalBoss1.SetActive(true);
        wallFinalBoss2.SetActive(true);
        theVillageMusic.Stop();
        finalBossMusic.Play();
        missionCanvas.SetActive(false);
    }

}
