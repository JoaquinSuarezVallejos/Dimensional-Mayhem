using EmeraldAI.Example;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public static PlayerHealth Instance;
    public int currentHealth;
    EmeraldAIPlayerHealth playerHealth;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(Instance.gameObject);
        }
    }

    public void GetCurrentHealth()
    {
        playerHealth = GameObject.Find("PlayerController").GetComponent<EmeraldAIPlayerHealth>();
        currentHealth = playerHealth.CurrentHealth;
    }
}
