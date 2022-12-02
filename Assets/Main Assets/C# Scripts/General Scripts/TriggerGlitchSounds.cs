using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGlitchSounds : MonoBehaviour
{
    public AudioSource glitchSoundEffect;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ProximityCollider")
        {
            glitchSoundEffect.Play();
        }
    }
}
