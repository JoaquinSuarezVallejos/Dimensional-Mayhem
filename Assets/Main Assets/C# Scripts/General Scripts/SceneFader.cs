using EmeraldAI.Example;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneFader : MonoBehaviour
{
    public float fadeDuration;
    public Color fadeColor;
    public Renderer rend;
    GameObject Player;
    EmeraldAIPlayerHealth Health;
    bool hasOcurred = false;
    string sceneName = string.Empty;
    LevelDeath levelDeath;
    HealthSaver healthSaver;

    //Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("PlayerController");
        Health = Player.GetComponent<EmeraldAIPlayerHealth>();
        rend = GetComponent<Renderer>();
        rend.enabled = false;
        levelDeath = GameObject.Find("LEVEL DEATH INFO").GetComponent<LevelDeath>();
        healthSaver = GameObject.Find("HEALTH SAVER").GetComponent<HealthSaver>();
    }

    public void FadeOut(string name)
    {
        sceneName = name;
        if (!hasOcurred)
        {
            Fade(0, 1);
            rend.enabled = true;
            hasOcurred = true;
            levelDeath.GetSceneName();
            healthSaver.GetCurrentHealth();
        }
    }

    public void Fade(float alphaIn, float alphaOut)
    {
        rend.enabled = true;
        Debug.Log("Fading");
        StartCoroutine(FadeRoutine(alphaIn, alphaOut));
    }

    public IEnumerator FadeRoutine(float alphaIn, float alphaOut)
    {
        rend.enabled = true;
        float timer = 0;
        while (timer <= fadeDuration)
        {
            Color newColor = fadeColor;
            newColor.a = Mathf.Lerp(alphaIn, alphaOut, timer / fadeDuration);

            rend.material.SetColor("_BaseColor", newColor);

            timer += Time.deltaTime;
            yield return null;
        }

        Color new_Color = fadeColor;
        new_Color.a = alphaOut;

        rend.material.SetColor("_BaseColor", new_Color);

        Debug.Log("Finished");
        SceneManager.LoadScene(sceneName);
    }
}
