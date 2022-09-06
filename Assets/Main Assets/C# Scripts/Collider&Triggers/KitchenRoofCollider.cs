using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenRoofCollider : MonoBehaviour
{
    public GameObject kitchenCollider;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ProximityCollider")
        {
            kitchenCollider.SetActive(true);
        }   
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "ProximityCollider")
        {
            kitchenCollider.SetActive(true);
        }   
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "ProximityCollider")
        {
            kitchenCollider.SetActive(false);
        }   
    }
}
