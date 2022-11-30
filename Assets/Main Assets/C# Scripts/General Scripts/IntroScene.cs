using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroScene : MonoBehaviour
{
    public GameObject barUI, firstText, secondText, thirdText, fourthText, fifthText, sixthText, buttonNext;
    private int index = 0;
    SceneFader sceneFader;

    void Start()
    {
        index = 0;
        sceneFader = GameObject.Find("Fader Screen").GetComponent<SceneFader>();
    }

    public void NextScene()
    {
        StartCoroutine("FadeOut");
    }

    IEnumerator FadeOut()
    {
        yield return new WaitForSeconds(3);
        sceneFader.FadeOut("Ancient Dungeon");
    }

    IEnumerator Index0()
    {
        buttonNext.GetComponent<Button>().enabled = false;
        secondText.GetComponent<Animator>().Play("2ndText FadeOut");
        yield return new WaitForSeconds(1);
        secondText.SetActive(false);
        thirdText.GetComponent<Animator>().Play("3rdText FadeIn");
        yield return new WaitForSeconds(1);
        thirdText.GetComponent<Animator>().Play("3rdText IdleActive");
        buttonNext.GetComponent<Button>().enabled = true;
    }

    IEnumerator Index1()
    {
        buttonNext.GetComponent<Button>().enabled = false;
        thirdText.GetComponent<Animator>().Play("3rdText FadeOut");
        yield return new WaitForSeconds(1);
        thirdText.SetActive(false);
        fourthText.GetComponent<Animator>().Play("4thText FadeIn");
        yield return new WaitForSeconds(1);
        fourthText.GetComponent<Animator>().Play("4thText IdleActive");
        buttonNext.GetComponent<Button>().enabled = true;
    }

    IEnumerator Index2()
    {
        buttonNext.GetComponent<Button>().enabled = false;
        fourthText.GetComponent<Animator>().Play("4thText FadeOut");
        yield return new WaitForSeconds(1);
        fourthText.SetActive(false);
        fifthText.GetComponent<Animator>().Play("5thText FadeIn");
        yield return new WaitForSeconds(1);
        fifthText.GetComponent<Animator>().Play("5thText IdleActive");
        buttonNext.GetComponent<Button>().enabled = true;
    }

    IEnumerator Index3()
    {
        buttonNext.GetComponent<Button>().enabled = false;
        fifthText.GetComponent<Animator>().Play("5thText FadeOut");
        firstText.GetComponent<Animator>().Play("1stText FadeOut");
        barUI.GetComponent<Animator>().Play("Bar FadeOut");
        yield return new WaitForSeconds(1);
        fifthText.SetActive(false);
        firstText.SetActive(false);
        barUI.SetActive(false);
        buttonNext.SetActive(false);
        sixthText.GetComponent<Animator>().Play("6thText FadeIn");
        yield return new WaitForSeconds(1);
        sixthText.GetComponent<Animator>().Play("6thText IdleActive");
        buttonNext.GetComponent<Button>().enabled = true;
    }

    public void NextText()
    {
        if (index == 0)
        {
            StartCoroutine("Index0");
            index++;
        }

        else if (index == 1)
        {
            StartCoroutine("Index1");
            index++;
        }

        else if (index == 2)
        {
            StartCoroutine("Index2");
            index++;
        }

        else if (index == 3)
        {
            StartCoroutine("Index3");
            index++;
            NextScene();
        }
    }
}
