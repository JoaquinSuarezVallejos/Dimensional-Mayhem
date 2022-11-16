using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EmeraldAI.Example;

public class PlayerHealthUpdater : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("PlayerController");
        player.GetComponent<EmeraldAIPlayerHealth>().CurrentHealth = GameObject.Find("HEALTH SAVER").GetComponent<HealthSaver>().health;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
