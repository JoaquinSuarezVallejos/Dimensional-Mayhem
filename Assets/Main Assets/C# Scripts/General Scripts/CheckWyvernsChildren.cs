using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckWyvernsChildren : MonoBehaviour
{
    public static bool AllWyvernsDead;

    void Start()
    {
        AllWyvernsDead = false;
    }

    void FixedUpdate()
    {
        if (transform.childCount == 0)
        {
            AllWyvernsDead = true;
        }
    }
}
