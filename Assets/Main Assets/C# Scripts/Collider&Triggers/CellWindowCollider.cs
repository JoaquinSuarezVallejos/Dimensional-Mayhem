using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellWindowCollider : MonoBehaviour
{
    public GameObject WindowCollider;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ProximityCollider")
        {
            WindowCollider.SetActive(true);
        }   
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "ProximityCollider")
        {
            WindowCollider.SetActive(true);
        }   
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "ProximityCollider")
        {
            WindowCollider.SetActive(false);
        }   
    }
}
