using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDestroyer : MonoBehaviour
{
    GameObject[] enemies;
    GameObject wall;

    // Start is called before the first frame update
    void Start()
    {
        enemies = GameObject.FindGameObjectsWithTag("Respawn");
        wall = GameObject.FindGameObjectWithTag("Wall");
    }

    // Update is called once per frame
    void Update()
    {
        if (enemies.Length == 0)
        {
            wall.SetActive(false);
        }
    }
}
