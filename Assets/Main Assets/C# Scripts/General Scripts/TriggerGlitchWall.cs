using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGlitchWall : MonoBehaviour
{
    SceneFader sceneFader;

    void Start()
    {
        sceneFader = GameObject.Find("Fader Screen").GetComponent<SceneFader>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ProximityCollider")
        {
            sceneFader.FadeOut("Main Menu");
        }
    }
}
