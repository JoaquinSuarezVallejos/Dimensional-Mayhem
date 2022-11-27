using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : MonoBehaviour
{
    public GameObject healthPotion, healEffect;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ItemCollider")
        {
            healthPotion.SetActive(false);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "ItemCollider")
        {
            healthPotion.SetActive(false);
            healEffect.SetActive(true);
        }
    }
}
