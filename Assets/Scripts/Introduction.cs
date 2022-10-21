using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Introduction : MonoBehaviour
{
    [SerializeField] string[] introduction;
    [SerializeField] Text text;
    int index = 0;
    public bool hasFinished = false;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
        text.text = introduction[0];
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (index == introduction.Length)
        {
            gameObject.SetActive(false);
            text.text = null; // or string.Empty if null doesn't work.
        }
        if (index < introduction.Length)
        {
            text.text = introduction[index];
        }
    }

    public void NextText()
    {
        index++;
    }
}
