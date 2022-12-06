using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCrystalAltar : MonoBehaviour
{
    public GameObject crystalAltar, spawnParticleEffect;
    public AudioSource spawnSoundEffect;

    void FixedUpdate()
    {
        if (CheckWyvernsChildren.AllWyvernsDead == true && CheckHydrasChildren.AllHydrasDead == true)
        {
            crystalAltar.SetActive(true);
            spawnSoundEffect.Play();
            spawnParticleEffect.SetActive(true);
        }
    }
    
}
