using BNG;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateMovement : MonoBehaviour
{
    InputBridge PlayerMovement;

    // Start is called before the first frame update
    void Start()
    {
        PlayerMovement = GameObject.Find("XR Rig Advanced").GetComponent<InputBridge>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerMovement.enabled)
        {
            PlayerMovement.enabled = false;
        }
    }
}
