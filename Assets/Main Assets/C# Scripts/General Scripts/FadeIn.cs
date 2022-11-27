using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn : MonoBehaviour
{
    SceneFader sceneFader;

    private void Awake()
    {
        sceneFader.rend.enabled = false;
        sceneFader.fadeColor.a = 0;
    }
}
