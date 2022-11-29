using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(GameObject.Find("PLAYER SAVER"));
        GameObject.Find("CenterEyeAnchor").transform.position = GameObject.FindGameObjectWithTag("Spawner").transform.position;
        GameObject.Find("CenterEyeAnchor").transform.rotation = GameObject.FindGameObjectWithTag("Spawner").transform.rotation;
    }
}
