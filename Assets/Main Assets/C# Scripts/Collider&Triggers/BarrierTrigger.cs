using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierTrigger : MonoBehaviour
{
    public GameObject barrierCollider1, barrierCollider2;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ProximityCollider")
        {
            barrierCollider1.SetActive(true);
            barrierCollider2.SetActive(true);
        }   
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "ProximityCollider")
        {
            barrierCollider1.SetActive(true);
            barrierCollider2.SetActive(true);
        }   
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "ProximityCollider")
        {
            barrierCollider1.SetActive(false);
            barrierCollider2.SetActive(false);
        }   
    }
}
