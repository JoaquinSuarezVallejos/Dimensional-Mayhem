using BNG;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Introduction : MonoBehaviour
{
    public string[] introduction;
    [SerializeField] Text text;
    public int index = 0;
    public bool hasFinished = false;
    SceneFader sceneFader;
    [SerializeField] Text NextBtnTxt;
    [SerializeField] string GoToTutorial;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
        text.text = introduction[0];
        sceneFader = GameObject.Find("Fader Screen").GetComponent<SceneFader>();
    }

    // Update is called once per frame
    void Update()
    {
        if (index == introduction.Length)
        {
            gameObject.SetActive(false);
            text.text = null; // or string.Empty if null doesn't work.
            hasFinished = true;
        }
        if (index < introduction.Length)
        {
            text.text = introduction[index];
        }
        if (index == introduction.Length - 1)
        {
            NextBtnTxt.text = GoToTutorial;
        }
        if (hasFinished)
        {
            NextScene("Tutorial");
        }
    }

    public void NextText()
    {
        index++;
    }

    public void NextScene (string SceneName)
    {
        sceneFader.FadeOut(SceneName);
    }
}
