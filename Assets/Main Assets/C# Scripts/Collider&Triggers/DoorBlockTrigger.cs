using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBlockTrigger : MonoBehaviour
{
    public GameObject DoorBlockCollider;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ProximityCollider")
        {
            DoorBlockCollider.SetActive(true);
        }   
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "ProximityCollider")
        {
            DoorBlockCollider.SetActive(true);
        }   
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "ProximityCollider")
        {
            DoorBlockCollider.SetActive(false);
        }   
    }
}
