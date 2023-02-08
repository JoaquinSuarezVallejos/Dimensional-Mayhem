using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EmeraldAI.Example;

public class SpeedPotion : MonoBehaviour
{
    public GameObject speedLiquid, speedBoostEffect;
    public AudioSource speedSoundEffect;
    public static bool speedEffectActive = false;

    void OnTriggerEnter(Collider other)
    {
        if (speedEffectActive == false)
        {
            if (other.gameObject.tag == "ItemCollider")
            {
                AddSpeed();
            }
        }
    }

    void AddSpeed()
    {
        speedLiquid.SetActive(false);
        speedBoostEffect.SetActive(true);
        speedSoundEffect.Play();
        speedEffectActive = true;
        StartCoroutine(SpeedEffectTime());
    }

    IEnumerator SpeedEffectTime()
    {
        yield return new WaitForSeconds(30);
        speedEffectActive = false;
    }
}
