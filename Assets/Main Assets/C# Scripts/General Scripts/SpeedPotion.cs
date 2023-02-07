using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EmeraldAI.Example;

public class SpeedPotion : MonoBehaviour
{
    public GameObject speedLiquid, speedBoostEffect;
    public int currentPlayerSpeed, speedAmount;
    public AudioSource speedSoundEffect;
    bool potionConsumed = false;

    void OnTriggerEnter(Collider other)
    {
        if (potionConsumed == false)
        {
            if (other.gameObject.tag == "ItemCollider")
            {
                speedLiquid.SetActive(false);
                speedBoostEffect.SetActive(true);
                AddHealth();
                speedSoundEffect.Play();
                potionConsumed = true;
            }
        }
    }

    public void AddHealth()
    {
        GameObject.Find("PlayerController").GetComponent<EmeraldAIPlayerHealth>().CurrentHealth += speedAmount;
    }
    
}
