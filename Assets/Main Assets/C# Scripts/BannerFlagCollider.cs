using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BannerFlagCollider : MonoBehaviour
{
    public GameObject FlagBannerCollider;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ProximityCollider")
        {
            FlagBannerCollider.SetActive(true);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "ProximityCollider")
        {
            FlagBannerCollider.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "ProximityCollider")
        {
            FlagBannerCollider.SetActive(false);
        }
    }
}
