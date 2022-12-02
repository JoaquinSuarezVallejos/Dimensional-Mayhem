using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBlockEndSceneDoor : MonoBehaviour
{
    public GameObject BlockDoorCube;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ProximityCollider")
        {
            BlockDoorCube.SetActive(true);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "ProximityCollider")
        {
            BlockDoorCube.SetActive(true);
        }
    }
}
