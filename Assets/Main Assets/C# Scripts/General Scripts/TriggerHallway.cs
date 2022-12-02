using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHallway : MonoBehaviour
{
    public GameObject HallWayStructure, TriggerHallway2;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ProximityCollider")
        {
            HallWayStructure.SetActive(true);
            TriggerHallway2.SetActive(true);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "ProximityCollider")
        {
            HallWayStructure.SetActive(true);
            TriggerHallway2.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "ProximityCollider")
        {
            HallWayStructure.SetActive(false);
            TriggerHallway2.SetActive(true);
        }
    }
}
