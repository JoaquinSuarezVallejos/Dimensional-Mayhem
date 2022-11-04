using BNG;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImmovablePlayer : MonoBehaviour
{
    InputBridge PlayerMovement;
    Introduction introduction;

    // Start is called before the first frame update
    void Start()
    {
        PlayerMovement = GameObject.Find("XR Rig Advanced").GetComponent<InputBridge>();
        introduction = GameObject.Find("Introduction").GetComponent<Introduction>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerMovement.enabled)
        {
            PlayerMovement.enabled = false;
        }
        if (introduction.hasFinished)
        {
            PlayerMovement.enabled = true;
        }
    }
}
