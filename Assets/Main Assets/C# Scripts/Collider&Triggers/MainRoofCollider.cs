using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainRoofCollider : MonoBehaviour
{
    public GameObject mainRoofCollider;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ProximityCollider")
        {
            mainRoofCollider.SetActive(true);
        }   
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "ProximityCollider")
        {
            mainRoofCollider.SetActive(true);
        }   
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "ProximityCollider")
        {
            mainRoofCollider.SetActive(false);
        }   
    }
}
