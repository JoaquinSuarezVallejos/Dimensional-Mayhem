using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGoblinsChildren : MonoBehaviour
{
    public static bool AllGoblinsDead;

    void Start()
    {
        AllGoblinsDead = false;
    }

    void FixedUpdate()
    {
        if (transform.childCount == 0)
        {
            AllGoblinsDead = true;
        }
    }
}

