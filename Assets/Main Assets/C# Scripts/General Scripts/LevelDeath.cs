using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelDeath : MonoBehaviour
{
    public string SceneName;
    public static LevelDeath Instance;
    Scene CurrentScene;

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

    public void GetSceneName()
    {
        CurrentScene = SceneManager.GetActiveScene();
        SceneName = CurrentScene.name;
    }
}