using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cupboard1Collider : MonoBehaviour
{
    public GameObject cupboard1Collider;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ProximityCollider")
        {
            cupboard1Collider.SetActive(true);
        }   
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "ProximityCollider")
        {
            cupboard1Collider.SetActive(true);
        }   
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "ProximityCollider")
        {
            cupboard1Collider.SetActive(false);
        }   
    }
}
