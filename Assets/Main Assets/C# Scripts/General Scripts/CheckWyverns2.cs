using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckWyverns2 : MonoBehaviour
{
    public static bool AllWyvernsDead2;

    void Start()
    {
        AllWyvernsDead2 = false;
    }

    void FixedUpdate()
    {
        if (transform.childCount == 0)
        {
            AllWyvernsDead2 = true;
        }
    }
}
