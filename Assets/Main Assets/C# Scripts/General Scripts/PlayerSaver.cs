using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSaver : MonoBehaviour
{
    public GameObject player;
    public static PlayerSaver Instance;

    void Awake()
    {
        if (SceneManager.GetActiveScene().name == "Death")
        {
            Destroy(Instance.gameObject);
        }
        else if (SceneManager.GetActiveScene().name != "Death")
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
    }

    public void GetCurrentPlayer()
    {
        player = GameObject.Find("XR Rig Advanced");
    }
}
