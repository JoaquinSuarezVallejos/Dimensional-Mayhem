using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cupboard2Collider : MonoBehaviour
{
    public GameObject cupboard2Collider;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ProximityCollider")
        {
            cupboard2Collider.SetActive(true);
        }   
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "ProximityCollider")
        {
            cupboard2Collider.SetActive(true);
        }   
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "ProximityCollider")
        {
            cupboard2Collider.SetActive(false);
        }   
    }
}
