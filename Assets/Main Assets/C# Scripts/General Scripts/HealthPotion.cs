using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EmeraldAI.Example;

    public class HealthPotion : MonoBehaviour
    {
        public GameObject healthPotion, healEffect;
        public int currentPlayerHealth, healAmount;
        public AudioSource healSoundEffect;

        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "ItemCollider")
            {
                healthPotion.SetActive(false);
                healEffect.SetActive(true);
                AddHealth();
                healSoundEffect.Play();
            }
        }

        public void AddHealth()
        {
            GameObject.Find("PlayerController").GetComponent<EmeraldAIPlayerHealth>().CurrentHealth += healAmount;
        }
    }

