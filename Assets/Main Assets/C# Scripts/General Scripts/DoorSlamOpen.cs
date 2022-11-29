using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSlamOpen : MonoBehaviour
{
    public GameObject TriggerDoorPlate1, WoodenDoorSlam;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "FloorProximity")
        {
            TriggerDoorPlate1.SetActive(false);

            // Play DoorSlamOpen Animation
            WoodenDoorSlam.GetComponent<Animator>().Play("DoorSlamOpen");
        }
    }
}
