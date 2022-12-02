using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalBossDeath : MonoBehaviour
{
    SceneFader sceneFader;

    void Start()
    {
        sceneFader = GameObject.Find("Fader Screen").GetComponent<SceneFader>();
    }

    IEnumerator FadeEndScene()
    {
        yield return new WaitForSeconds(4);
        sceneFader.FadeOut("End Scene");
    }

    public void FadeToEndScene()
    {
        StartCoroutine("FadeEndScene");
    }
}
