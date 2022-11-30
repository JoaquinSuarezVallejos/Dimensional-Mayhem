using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitGame : MonoBehaviour
{
    SceneFader sceneFader;

    void Start()
    {
        sceneFader = GameObject.Find("Fader Screen").GetComponent<SceneFader>();
    }

    public void ExitGameFunction()
    {
        sceneFader.ExitFadeOut();
    }
}
