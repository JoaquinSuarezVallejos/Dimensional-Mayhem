using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    Transform spawnPoint;
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = GameObject.FindGameObjectWithTag("Spawner").transform;
        player = GameObject.Find("XR Rig Advanced");
        player.transform.position = spawnPoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
