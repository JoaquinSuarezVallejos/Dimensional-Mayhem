using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using EmeraldAI.Example;

public class HealthSaver : MonoBehaviour
{
    public int health;
    public static HealthSaver Instance;

    void Awake()
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
        health = GameObject.Find("PlayerController").GetComponent<EmeraldAIPlayerHealth>().CurrentHealth;
    }
}
