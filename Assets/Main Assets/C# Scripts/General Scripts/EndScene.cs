using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScene : MonoBehaviour
{
    SceneFader sceneFader;

    void Start()
    {
        sceneFader = GameObject.Find("Fader Screen").GetComponent<SceneFader>();
    }

    public void FadeToEndScene()
    {
        sceneFader.FadeOut("End Scene");
    }
}
