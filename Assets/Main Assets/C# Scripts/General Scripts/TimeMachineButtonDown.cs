using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeMachineButtonDown : MonoBehaviour
{
    public GameObject timeMachine, electricityEffect, finalBoss, bossSpawnEffect, wallFinalBoss1, wallFinalBoss2, missionCanvas, flames, initializeTxt, errorTxt;
    public AudioSource finalBossMusic, theVillageMusic;

    public void buttonPressed()
    {
        missionCanvas.SetActive(false);
        electricityEffect.SetActive(true);
        initializeTxt.SetActive(false);
        StartCoroutine("errorTxtBlink1");
        timeMachine.GetComponent<Animator>().Play("TimeMachineError");

        finalBoss.SetActive(true); 
        bossSpawnEffect.SetActive(true);
        flames.SetActive(true);
        wallFinalBoss1.SetActive(true);
        wallFinalBoss2.SetActive(true);

        theVillageMusic.Stop();
        finalBossMusic.Play();
        GameObject.Find("InnerButton").GetComponent<ButtonFader>().enabled = false;
    }

    IEnumerator errorTxtBlink1()
    {
        errorTxt.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        StartCoroutine("errorTxtBlink2");
    }

    IEnumerator errorTxtBlink2()
    {
        errorTxt.SetActive(false);
        yield return new WaitForSeconds(0.2f);
        StartCoroutine("errorTxtBlink1");
    }
}
