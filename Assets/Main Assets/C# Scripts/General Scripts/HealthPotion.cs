using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EmeraldAI.Example;

    public class HealthPotion : MonoBehaviour
    {
        public GameObject healthPotion, healEffect;
        public int currentPlayerHealth, healAmount;

        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "ItemCollider")
            {
                healthPotion.SetActive(false);
                healEffect.SetActive(true);
                AddHealth();
            }
        }

        /*public void GetCurrentHealth()
        {
            currentPlayerHealth = GameObject.Find("PlayerController").GetComponent<EmeraldAIPlayerHealth>().CurrentHealth;
        }*/

        public void AddHealth()
        {
            //currentPlayerHealth += 30;
            GameObject.Find("PlayerController").GetComponent<EmeraldAIPlayerHealth>().CurrentHealth += healAmount;
        }
    }

