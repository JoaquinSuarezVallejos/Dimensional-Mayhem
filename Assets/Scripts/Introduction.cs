using BNG;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Introduction : MonoBehaviour
{
    public string[] introduction;
    [SerializeField] Text text;
    public int index = 0;
    public bool hasFinished = false;
    InputBridge PlayerMovement;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
        text.text = introduction[0];
        PlayerMovement = GameObject.Find("XR Rig Advanced").GetComponent<InputBridge>();
    }

    // Update is called once per frame
    void Update()
    {
        if (index == introduction.Length)
        {
            PlayerMovement.enabled = true;
            gameObject.SetActive(false);
            text.text = null; // or string.Empty if null doesn't work.
            hasFinished = true;
        }
        if (index < introduction.Length)
        {
            text.text = introduction[index];
            PlayerMovement.enabled = false;
        }
    }

    public void NextText()
    {
        index++;
    }
}
