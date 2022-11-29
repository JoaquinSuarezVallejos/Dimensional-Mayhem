using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(GameObject.Find("PLAYER SAVER"));
        GameObject.Find("PlayerController").transform.position = GameObject.FindGameObjectWithTag("Spawner").transform.position;
        GameObject.Find("PlayerController").transform.rotation = GameObject.FindGameObjectWithTag("Spawner").transform.rotation;
    }
}
