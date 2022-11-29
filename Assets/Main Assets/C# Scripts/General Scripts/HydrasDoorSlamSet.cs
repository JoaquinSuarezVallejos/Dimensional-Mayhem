using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HydrasDoorSlamSet : MonoBehaviour
{
    public static bool HydrasSetDead;

    void Start()
    {
        HydrasSetDead = false;
    }

    void FixedUpdate()
    {
        if (transform.childCount == 0)
        {
            HydrasSetDead = true;
            Destroy(this.gameObject);
        }
    }
}
