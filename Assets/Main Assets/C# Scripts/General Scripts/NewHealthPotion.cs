using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EmeraldAI.Example;

    public class NewHealthPotion : MonoBehaviour
    {
        public GameObject healthLiquid, healEffect;
        public int healAmount;
        public AudioSource healSoundEffect;
        bool potionConsumed = false;

        void OnTriggerEnter(Collider other)
        {
            if (potionConsumed == false)
            {
                if (other.gameObject.tag == "ItemCollider")
                {
                    healthLiquid.SetActive(false);
                    healEffect.SetActive(true);
                    AddHealth();
                    healSoundEffect.Play();
                    potionConsumed = true;
                }
            }
        }

        public void AddHealth()
        {
            GameObject.Find("PlayerController").GetComponent<EmeraldAIPlayerHealth>().CurrentHealth += healAmount;
        }
    }