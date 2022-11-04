using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipIntroduction : MonoBehaviour
{
    Introduction Introduction;

    // Start is called before the first frame update
    void Start()
    {
        Introduction = GameObject.Find("Introduction").GetComponent<Introduction>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SkipText()
    {
        Introduction.index = Introduction.introduction.Length;
    }
}
