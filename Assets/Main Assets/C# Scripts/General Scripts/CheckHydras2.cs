using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckHydras2 : MonoBehaviour
{
    public static bool AllHydrasDead2;

    void Start()
    {
        AllHydrasDead2 = false;
    }

    void FixedUpdate()
    {
        if (transform.childCount == 0)
        {
            AllHydrasDead2 = true;
        }
    }
}
