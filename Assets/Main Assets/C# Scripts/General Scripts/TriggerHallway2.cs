using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHallway2 : MonoBehaviour
{
    public GameObject HallWayStructure, TriggerBlockEndSceneDoor;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ProximityCollider")
        {
            HallWayStructure.SetActive(true);
            TriggerBlockEndSceneDoor.SetActive(true);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "ProximityCollider")
        {
            HallWayStructure.SetActive(true);
            TriggerBlockEndSceneDoor.SetActive(true);
        }
    }
}