using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrisonWallCollider : MonoBehaviour
{
    public GameObject WallPrisonCollider;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ProximityCollider")
        {
            WallPrisonCollider.SetActive(true);
        }   
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "ProximityCollider")
        {
            WallPrisonCollider.SetActive(true);
        }   
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "ProximityCollider")
        {
            WallPrisonCollider.SetActive(false);
        }   
    }
}
