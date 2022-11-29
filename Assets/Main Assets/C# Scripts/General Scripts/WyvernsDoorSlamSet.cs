using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WyvernsDoorSlamSet : MonoBehaviour
{
    public static bool WyvernsSetDead;

    void Start()
    {
        WyvernsSetDead = false;
    }

    void FixedUpdate()
    {
        if (transform.childCount == 0)
        {
            WyvernsSetDead = true;
            Destroy(this.gameObject);
        }
    }
}
