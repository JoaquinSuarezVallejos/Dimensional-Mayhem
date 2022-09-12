using BNG;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateMovement : MonoBehaviour
{
    InputBridge PlayerMovement;
    GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("XR Rig Advanced");
        PlayerMovement = Player.GetComponent<InputBridge>();
        PlayerMovement.enabled = false; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
