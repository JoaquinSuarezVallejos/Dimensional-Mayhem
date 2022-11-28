using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckHydrasChildren : MonoBehaviour
{
    public static bool AllHydrasDead;

    void Start()
    {
        AllHydrasDead = false;
    }

    void FixedUpdate()
    {
        if (transform.childCount == 0)
        {
            AllHydrasDead = true;
        }
    }
}
