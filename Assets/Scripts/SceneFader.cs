using EmeraldAI.Example;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneFader : MonoBehaviour
{
    public float fadeDuration = 2;
    public Color fadeColor;
    Renderer rend;
    GameObject Player;
    EmeraldAIPlayerHealth Health;

    //Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("PlayerController");
        Health = Player.GetComponent<EmeraldAIPlayerHealth>();
        rend = GetComponent<Renderer>();
        FadeOut();
    }

    public void FadeOut()
    {
        Fade(0, 1);
    }

    public void Fade(float alphaIn, float alphaOut)
    {
        Debug.Log("Fading");
        StartCoroutine(FadeRoutine(alphaIn, alphaOut));
    }

    public IEnumerator FadeRoutine(float alphaIn, float alphaOut)
    {
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
    }
}
