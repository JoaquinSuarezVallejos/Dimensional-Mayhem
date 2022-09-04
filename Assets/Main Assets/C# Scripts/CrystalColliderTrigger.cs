using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalColliderTrigger : MonoBehaviour
{
    public GameObject CrystalCollider;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ProximityCollider")
        {
            CrystalCollider.SetActive(true);
        }   
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "ProximityCollider")
        {
            CrystalCollider.SetActive(true);
        }   
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "ProximityCollider")
        {
            CrystalCollider.SetActive(false);
        }   
    }
}
