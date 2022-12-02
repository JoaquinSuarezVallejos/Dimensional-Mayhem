using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialTriggerHallway : MonoBehaviour
{
    public GameObject TriggerHallway1;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ProximityCollider")
        {
            TriggerHallway1.SetActive(true);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "ProximityCollider")
        {
            TriggerHallway1.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "ProximityCollider")
        {
            TriggerHallway1.SetActive(false);
        }
    }
}
